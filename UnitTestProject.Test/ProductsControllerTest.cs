using Microsoft.AspNetCore.Mvc;
using Moq;
using UnitTestProject.Web.Controllers;
using UnitTestProject.Web.Models;
using UnitTestProject.Web.Repository;

namespace UnitTestProject.Test
{
    public class ProductsControllerTest
    {
        private readonly Mock<IRepository<Product>> _mockRepo;
        private readonly ProductsController _controller;
        private List<Product> products;

        public ProductsControllerTest()
        {
            _mockRepo = new Mock<IRepository<Product>>();
            _controller = new ProductsController(_mockRepo.Object);

            products = new List<Product>()
            {
                new Product() { Id = 1,Name = "Kalem",Color = "Siyah", Stock = 2,Price = 230},
                new Product() { Id = 2,Name = "Silgi",Color = "Beyaz", Stock = 2,Price = 230}
            };

        }


        [Fact]
        public async void Index_ActionExecutes_ReturnView()
        {
            var result = await _controller.Index();

            Assert.IsType<ViewResult>(result);
        }


    }
}
