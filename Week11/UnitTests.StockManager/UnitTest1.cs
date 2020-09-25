using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using StockManagerPrj;
using Moq;
using Shouldly;

namespace UnitTests.StockManager
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_StockHas2Elem_Then_ShouldReturnTotalPrice()
        {
            //Arrange
            List<StockManagerPrj.StockElement> listStockElem = new List<StockElement> {
                new StockElement
                {
                    Name="Mere",
                    Currency="RON",
                    Quantity=10,
                    PricePerUnit=2
                },
                new StockElement
                {
                    Name="Pere",
                    Currency="RON",
                    Quantity=1,
                    PricePerUnit=5
                }
            };
            var stockProv = new Mock<IStockProvider>();            stockProv.Setup(s => s.GetStock()).Returns(listStockElem);
            var expectedStockPrice = 25;
            StockManagerPrj.StockManager stockManager = new StockManagerPrj.StockManager(stockProv.Object,null);
            //Act

            var actualStock =stockManager.CalculateStock();
            //Assert
            actualStock.ShouldBe(expectedStockPrice);
        }
        [TestMethod]
        public void When_StockHas2ElemWithDiffCurrency_Then_ShouldConvertTotalPrice()
        {
            //Arrange
            List<StockManagerPrj.StockElement> listStockElem = new List<StockElement> {
                new StockElement
                {
                    Name="Mere",
                    Currency="EUR",
                    Quantity=10,
                    PricePerUnit=2
                },
                new StockElement
                {
                    Name="Pere",
                    Currency="RON",
                    Quantity=1,
                    PricePerUnit=5
                }
            };

            var stockProv = new Mock<IStockProvider>();
            stockProv.Setup(s => s.GetStock()).Returns(listStockElem);

            var currencyProv = new Mock<ICurrencyConverter>();
            currencyProv.Setup(x => x.Convert(It.Is<double>(y => y == 2), "EUR")).Returns(9.5);


            var expectedStockPrice = 100;
            StockManagerPrj.StockManager stockManager = new StockManagerPrj.StockManager(stockProv.Object, currencyProv.Object);
            //Act

            var actualStock = stockManager.CalculateStock();
            //Assert
            actualStock.ShouldBe(expectedStockPrice);
            currencyProv.Verify(x => x.Convert(It.Is<double>(y => y == 2), "EUR"),Times.Once);

        }
    }
}
