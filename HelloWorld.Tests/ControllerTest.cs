using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HelloWorld.Models;
using HelloWorld.Controllers;
using Moq;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Tests
{
    public class ControllerTest
    {
        [Fact]
        public void getMessagesSuccess()
        {
            //arrange
            var mock = new Mock<IMessage>();
            mock.SetupGet(m => m.Messages).Returns(new List<Message> { new Message { Sender = "Fnu Masnaga", Content = "Hello World" }}.AsQueryable());
            var controller = new MessageController (mock.Object);

            //act
            IActionResult result = controller.GetMessage();

            //assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsType<string>(okResult.Value);
            Assert.Equal("Hello World. From Fnu Masnaga", okResult.Value);
        }

        [Fact]
        public void getMessageFromNullData()
        {
            //arrange
            var mock = new Mock<IMessage>();
            mock.SetupGet(m => m.Messages).Returns(new List<Message> { null }.AsQueryable());
            var controller = new MessageController(mock.Object);

            //act
            IActionResult result = controller.GetMessage();

            //assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
