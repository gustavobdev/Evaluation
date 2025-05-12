using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Events;

/// <summary>
/// Classe responsável por registrar logs de eventos de venda.
/// </summary>
public class SaleEventsLogger
{
    public void LogSaleCreated(Sale sale)
    {
        Console.WriteLine($"[EVENTO] SaleCreated - Venda {sale.SaleNumber} criada em {sale.SaleDate}");
    }

    public void LogSaleModified(Sale sale)
    {
        Console.WriteLine($"[EVENTO] SaleModified - Venda {sale.SaleNumber} modificada.");
    }

    public void LogSaleCancelled(Sale sale)
    {
        Console.WriteLine($"[EVENTO] SaleCancelled - Venda {sale.SaleNumber} cancelada.");
    }

    public void LogItemCancelled(SaleItem item)
    {
        Console.WriteLine($"[EVENTO] ItemCancelled - Item {item.Product} cancelado.");
    }
}
