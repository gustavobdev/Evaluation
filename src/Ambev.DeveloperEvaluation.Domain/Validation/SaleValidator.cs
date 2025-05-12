using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    /// <summary>
    /// Serviço de validação para garantir integridade das vendas e regras de negócio.
    /// </summary>
    public class SaleValidationService
    {
        /// <summary>
        /// Valida uma venda antes de ser registrada no sistema.
        /// </summary>
        /// <param name="sale">Venda a ser validada.</param>
        /// <exception cref="InvalidOperationException">Exceção caso alguma regra seja violada.</exception>
        public void ValidateSale(Sale sale)
        {
            if (sale.Items == null || sale.Items.Count == 0)
            {
                throw new InvalidOperationException("A venda deve conter pelo menos um item.");
            }

            foreach (var item in sale.Items)
            {
                ValidateSaleItem(item);
            }
        }

        /// <summary>
        /// Valida um item de venda garantindo regras de quantidade e preço.
        /// </summary>
        /// <param name="item">Item a ser validado.</param>
        /// <exception cref="InvalidOperationException">Exceção caso alguma regra seja violada.</exception>
        private void ValidateSaleItem(SaleItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Product))
            {
                throw new InvalidOperationException("O produto deve ser informado.");
            }

            if (item.Quantity < 1)
            {
                throw new InvalidOperationException("A quantidade do produto deve ser pelo menos 1.");
            }

            if (item.UnitPrice <= 0)
            {
                throw new InvalidOperationException("O preço unitário do produto deve ser maior que zero.");
            }

            if (item.Quantity > 20)
            {
                throw new InvalidOperationException("Não é possível vender mais de 20 unidades do mesmo produto.");
            }
        }
    }
}
