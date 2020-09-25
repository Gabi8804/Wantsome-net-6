using System.Collections.Generic;

namespace StockManagerPrj
{
    public interface IStockProvider
    {
        List<StockElement> GetStock();
    }
}