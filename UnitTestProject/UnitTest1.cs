using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void BrakeMethod3()
        {
            CarClass car = new CarClass();            
            //Fail
            Assert.AreEqual(3, car.Speed());
        }
    }
}
