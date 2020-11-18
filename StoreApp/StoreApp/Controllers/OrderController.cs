using StoreApp.BusinessLogic;
using StoreApp.BusinessLogic.BusinessEntities;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.Controllers
{

    

    public class OrderController : Controller
    {
        private readonly ProductHandler productHandler;
        private readonly OrderHandler orderHandler;
        private readonly UserHandler userHandler;
        public OrderController()
        {
            productHandler = new ProductHandler();
            orderHandler = new OrderHandler();
            userHandler = new UserHandler();
        }
        // GET: Order
        public ActionResult Index()
        {
            var products = new List<ProductViewModel>();
            foreach (var p in ShoppingBag.orderList)
            {
                products.Add(new ProductViewModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    ProductId = p.ProductId,
                    Quantity = p.Quantity
                });
            }
            var order = new OrderViewModel()
            {
                Products = products
        };
            
            return View(order);
        }
        [HttpPost]
        [ActionName("Index")]
        public ActionResult PlaceOrder(OrderViewModel order)
        {
            var addressModel = new AddressModel
            {
                AddressLine1=order.AddressLine1,
                AddressLine2=order.AddressLine2,
                City=order.City,
                Postcode=order.Postcode,
                Province=order.Province
            };

            var userId = userHandler.GetUserIdByName(User.Identity.Name);
            var addressId = orderHandler.CreateAddressAndGetId(addressModel);
            foreach(var p in order.Products)
            {
                orderHandler.PlaceOrder(p.ProductId,p.Quantity, userId,addressId);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult AddToCart(string ProductId)
        {
            var prodId = int.Parse(ProductId);
            var product = productHandler.GetProduct(prodId);

            var productForCart = new ProductViewModel
            {
                Name=product.Name,
                Price=product.Price,
                Quantity=1,
                ProductId=product.ProductId
            };

            ShoppingBag.AddToCart(productForCart);

            return null;
        }


    }
}