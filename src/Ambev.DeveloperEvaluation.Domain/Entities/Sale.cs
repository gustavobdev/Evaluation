using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Representa uma venda no sistema.
/// </summary>
[XmlRoot("Sale")]
public class Sale
{
    [XmlElement("Id")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O número da venda é obrigatório.")]
    [StringLength(20, ErrorMessage = "O número da venda deve ter no máximo 20 caracteres.")]
    [XmlElement("SaleNumber")]
    public string SaleNumber { get; set; }

    [Required(ErrorMessage = "A data da venda é obrigatória.")]
    [XmlElement("SaleDate")]
    public DateTime SaleDate { get; set; }

    [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres.")]
    [XmlElement("Customer")]
    public string Customer { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "O valor total não pode ser negativo.")]
    [XmlElement("TotalAmount")]
    public decimal TotalAmount { get; set; }

    [Required(ErrorMessage = "A filial deve ser informada.")]
    [XmlElement("Branch")]
    public string Branch { get; set; }

    [XmlElement("Items")]
    public List<SaleItem> Items { get; set; } = new();

    [XmlElement("IsCancelled")]
    public bool IsCancelled { get; set; }
}
