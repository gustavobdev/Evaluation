using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Services;

/// <summary>
/// Serviço responsável por aplicar regras de negócio sobre vendas e calcular descontos.
/// </summary>
public class SaleService
{
    /// <summary>
    /// Aplica descontos aos itens de uma venda conforme as regras de quantidade.
    /// </summary>
    /// <param name="sale">Venda sobre a qual os descontos serão aplicados.</param>
    public void ApplyDiscounts(Sale sale)
    {
        foreach (var item in sale.Items)
        {
            if (item.Quantity >= 4 && item.Quantity < 10)
            {
                item.Discount = item.UnitPrice * item.Quantity * 0.10m;
            }
            else if (item.Quantity >= 10 && item.Quantity <= 20)
            {
                item.Discount = item.UnitPrice * item.Quantity * 0.20m;
            }
            else if (item.Quantity > 20)
            {
                throw new InvalidOperationException("Não é possível vender mais de 20 unidades do mesmo produto.");
            }
            else
            {
                item.Discount = 0;
            }
        }

        // Atualizar o total da venda
        sale.TotalAmount = sale.Items.Sum(i => i.TotalAmount);
    }
}
