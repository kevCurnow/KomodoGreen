using System;
using System.Collections.Generic;
using KomodoGreen.BLL;
using KomodoGreen.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreen.UnitTests
{
    [TestClass]
    public class HybridServiceTests
    {
        private HybridService _hybridService;
        private List<HybridCars> _hybridList;
        private HybridCars _hybrid;

        [TestInitialize]
        public void Arrange()
        {
            _hybridService = new HybridService();
            _hybridList = new List<HybridCars>();
            _hybrid = new HybridCars("Toyota", "Camry Hybrid", 2018, 51f, 53f, 33.46f);
        }
        [TestMethod]
        public void HybridService_ShouldCreateHybridCar_IsTypeHybrid()
        {
            //Act
            var actual = new HybridCars("Toyota", "Camry Hybrid", 2018, 51f, 53f, 33.46f);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(HybridCars));
        }
    }
}
