using System;
using Xunit;
using Simple.API.Controllers;

namespace Simple.Test
{
    public class UnitTest1
    {
        ValuesController _controller =  new ValuesController();
        public UnitTest1()
        {
           
        }

        [Fact]
        public void GetObjectById()
        {
            var returnObject = _controller.Get(1);
            Assert.Equal("Los Angeles", returnObject.Value);
        }
        [Fact]
        public void GetObjectList()
        {
            string[] returnObject = { "value1","value2","value3" };

            var returnControllerObject = _controller.Get();
            Assert.Equal(returnObject,returnControllerObject.Value);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
