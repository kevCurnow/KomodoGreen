using System;
using System.Collections.Generic;
using KomodoGreen.BLL;
using KomodoGreen.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoGreen.UnitTests
{
    [TestClass]
    public class GasServiceTests
    {
        private GasService _gasService;
        private List<GasCars> _gasList;
        private GasCars _gas;

        [TestInitialize]
        public void Arrange()
        {
            _gasService = new GasService();
            _gasList = new List<GasCars>();
            _gas = new GasCars("Jeep", "Renegade", 2016, 24f, 31f, 23.6f);
        }

        [TestMethod]
        public void GasService_ShouldCreateGasCar_IsTypeGas()
        {
            //Act
            var actual = _gasService.CreateGas("Jeep", "Renegade", 2016, 24f, 31f, 23.6f);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(GasCars));
        }
    }
}
