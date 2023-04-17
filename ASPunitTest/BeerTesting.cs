using ApiTest.Controllers;
using ApiTest.Models;
using ApiTest.Servicios;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ASPunitTest
{
    public class BeerTesting
    {
        private readonly BeerController _controller;
        private readonly IBeerService _service;

        public BeerTesting()
        {
            _service= new BeerService();
            _controller = new BeerController(_service);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void Get_Quantity()
        {
            var result = (OkObjectResult)_controller.Get();

            var beers = Assert.IsType<List<Beer>>(result.Value);
            Assert.True(beers.Count > 0);

        }

        [Fact]
        public void GetById_OK()
        {
           int id = 1;

            var result = _controller.GetById(id);

            Assert.IsType<OkObjectResult>(result);

        }
    }
}