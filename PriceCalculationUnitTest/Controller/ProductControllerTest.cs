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
    [TestClass]
    public class ProductControllerTest
    {
        Mock<PriceCalculationContext> mockPriceCalculation = new Mock<PriceCalculationContext>();
        ProductsController controller;

        [TestInitialize]
        public void TestInit()
        {
            List<ProductModel> products = new List<ProductModel>();
            ProductModel product = new ProductModel();
            product.Id = 1;
            product.Description = "item1";
            product.Price = 100;
            product.Quantity = 2;
            product.IsSelected = false;
            products.Add(product);
            mockPriceCalculation.Setup(a => a.Product).ReturnsDbSet(products);
            controller = new ProductsController(mockPriceCalculation.Object);
        }

        [TestMethod]
        public void VaildProductList()
        {
            var result = controller.Index();
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }   
    }
}
