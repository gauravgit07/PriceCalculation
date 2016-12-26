using System;
using Moq;
using System.Web.Http.Results;
using PriceCalculation.Controllers;
using PriceCalculation.Models;
using PriceCalculation.DAL;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriceCalculationUnitTest.Controller
{
    public class ShoppingCartControllerTest
    {
        Mock<PriceCalculationContext> mockPriceCalculation = new Mock<PriceCalculationContext>();
        ShoppingCartController controller;
        List<Item> cart;

        [TestInitialize]
        public void TestInit()
        {
            List<Item> cart = new List<Item>() { new Item() { Quantity = 1, Product=new ProductModel() {  Id =1, Description ="item1", Discount=true, Quantity = 1, IsSelected = false, Price = 100, State = "TX"} } };
            
            List<ProductModel> products = new List<ProductModel>();
            ProductModel product = new ProductModel();
            product.Id = 1;
            product.Description = "item1";
            product.Price = 100;
            product.Quantity = 2;
            product.IsSelected = false;
            products.Add(product);
            mockPriceCalculation.Setup(a => a.Product).ReturnsDbSet(products);
            controller = new ShoppingCartController(mockPriceCalculation.Object);
        }

        [TestMethod]
        public void ValidExistingId()
        {
            var result = controller.isExisting(1);
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }

    }
}
