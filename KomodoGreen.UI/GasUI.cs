using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Contracts;
using KomodoGreen.BLL;
using KomodoGreen.Data;


namespace KomodoGreen.UI
{
    public class GasUI
    {
        private static GasService _gasService;

        private static IConsole _realConsole;

        public GasUI(IConsole console)
        {
            _realConsole = console;
            _gasService = new GasService();
        }

        public float CheckMPG()
        {
            _realConsole.WriteLine("What are the miles per gallon for this car?");
            var mpg = UtilMethods.ReadLineConvertToFloat();
            return mpg;
        }

        public GasCars CreateGas(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float mpgInfo)
        {
            var gasCar = _gasService.CreateGas(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek, mpgInfo);
            return gasCar;
        }

        public void AddGas(GasCars gas)
        {
            _realConsole.WriteLine("Would you like to add this car to the list?");
            _gasService.AddGas(gas);
        }

        public static List<GasCars> CreateGasListForConsole()
        {
            var allGas = _gasService.GetAllGas();

            foreach (var g in allGas)
            {
                _realConsole.WriteLine($"{g.Make}, {g.MilesPerGallon}");
            }

            return allGas;
        }

        public List<GasCars> GetAllGas()
        {
            var gasList = _gasService.GetAllGas();
            return gasList;
        }

        public GasCars GetSingleGasInConsole(string make, string model)
        {
            try
            {
                var g = _gasService.Search(make, model);
                return g;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

    }

}
