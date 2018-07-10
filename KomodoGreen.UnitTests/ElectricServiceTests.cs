using System;
using System.Text;
using System.Collections.Generic;
using KomodoGreen.BLL;
using KomodoGreen.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreen.UnitTests
{
    
    [TestClass]
    public class ElectricServiceTests
    {
        private ElectricService _electricService;
        private List<ElectricCars> _electricList;
        private ElectricCars _electric;

        [TestInitialize]
        public void Arrange()
        {
            _electricService = new ElectricService();
            _electricList = new List<ElectricCars>();
            _electric = new ElectricCars("Tesla", "Model 3", 2018, 200, 0, 200.0f);
        }

        [TestMethod]
        public void ElectricService_ShouldCreateElectricCar_IsTypeElectric()
        {
            //Act
            var actual = new ElectricCars("Tesla", "Model 3", 2018, 200, 0, 200.0f);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(ElectricCars));
        }
    }
}
