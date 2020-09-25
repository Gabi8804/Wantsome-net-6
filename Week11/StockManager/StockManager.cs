using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagerPrj
{
   public class StockManager
    {
        private readonly ICurrencyConverter currencyConverter;

        private readonly IStockProvider stockProvider;


        public StockManager(IStockProvider stockProvider,ICurrencyConverter currencyConverter)
        {
            this.stockProvider = stockProvider;
            this.currencyConverter = currencyConverter;
        }
        public double CalculateStock()
        {


            var Stock = stockProvider.GetStock();
            double totalPrice = 0;
            foreach (var item in Stock)
            {
                if (item.Currency == "RON") { 
                var totalPriceperItem = item.PricePerUnit * item.Quantity;
                totalPrice += totalPriceperItem;
                }
                else
                {
                    double convertedAmmount = currencyConverter.Convert(item.PricePerUnit, item.Currency);
                    totalPrice += item.Quantity * convertedAmmount;
                }
            }

            return totalPrice;
        }
    }
}
