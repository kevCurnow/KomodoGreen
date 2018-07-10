using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.BLL;
using KomodoGreen.Data;

namespace KomodoGreen.UI
{
    public class ElectricUI
    {
        private static ElectricService _electricService;
        private static IConsole _realConsole;

        public ElectricUI(IConsole console)
        {
            _realConsole = console;
            _electricService = new ElectricService();
        }

        public float CheckMPG()
        {
            _realConsole.WriteLine("What are the miles per KWH for this electric vehicle?");
            var mpg = UtilMethods.ReadLineConvertToFloat();
            return mpg;
        }

        public ElectricCars CreateElectric(string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, float mpgInfo)
        {
            var electricCar = _electricService.CreateElectric(make, model, year, numberOfCityMilesPerWeek,
                numberOfHighwayMilesPerWeek, mpgInfo);
            return electricCar;
        }

        public void AddElectric(ElectricCars electric)
        {
            _realConsole.WriteLine("Would you like to add this car to the list?");
            _electricService.AddElectric(electric);
        }

        public static List<ElectricCars> CreateElectricListForConsole()
        {
            var allElectric = _electricService.GetAllElectric();
            foreach (var e in allElectric)
            {
                _realConsole.WriteLine($"{e.Make}, {e.MilesPerCharge}");
            }

            return allElectric;
        }

        public List<ElectricCars> GetAllElectric()
        {
            var electricList = _electricService.GetAllElectric();
            return electricList;
        }

        public ElectricCars GetSingleElectricInConsole(string make, string model)
        {
            try
            {
                var e = _electricService.Search(make, model);
                return e;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void DeleteElectricCar()
        {
            _realConsole.WriteLine("What is the make of the car that you'd like to delete?");

            string make = UtilMethods.ConsoleAskMake();
            string model = UtilMethods.ConsoleAskModel();

            try
            {
                _electricService.DeleteElectric(make, model);
                _realConsole.WriteLine("Car was deleted");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
