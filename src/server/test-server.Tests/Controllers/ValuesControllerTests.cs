using System;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using test_server.Controllers;
using Xunit;

namespace test_server.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Get_ReturnsArrayOfValues()
        {
            var controller = new ValuesController();

            var result = controller.Get();

            result.Should().BeOfType<OkObjectResult>();
            var okResult = (OkObjectResult)result;

            okResult.Value.Should().BeEquivalentTo(new[] {
                "value1", "value2"
            });
        }
    }
}
