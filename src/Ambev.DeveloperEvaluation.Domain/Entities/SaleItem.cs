using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Representa um item dentro de uma venda.
/// </summary>
[XmlRoot("SaleItem")]
public class SaleItem
{
    /// <summary>
    /// Identificador único do item.
    /// </summary>
    [XmlElement("Id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Nome ou identificador do produto.
    /// </summary>
    [XmlElement("Product")]
    public string Product { get; set; }

    /// <summary>
    /// Quantidade comprada do produto.
    /// </summary>
    [XmlElement("Quantity")]
    public int Quantity { get; set; }

    /// <summary>
    /// Preço unitário do produto.
    /// </summary>
    [XmlElement("UnitPrice")]
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Valor total de desconto aplicado.
    /// </summary>
    [XmlElement("Discount")]
    public decimal Discount { get; set; }

    /// <summary>
    /// Valor total do item após desconto.
    /// </summary>
    [XmlElement("TotalAmount")]
    public decimal TotalAmount => (UnitPrice * Quantity) - Discount;

    /// <summary>
    /// Indica se o item foi cancelado.
    /// </summary>
    [XmlElement("IsCancelled")]
    public bool IsCancelled { get; set; }
}
