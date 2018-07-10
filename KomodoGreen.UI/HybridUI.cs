using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.BLL;
using KomodoGreen.Data;

namespace KomodoGreen.UI
{
    public class HybridUI
    {
        private static HybridService _hybridService;
        private static IConsole _realConsole;

        public HybridUI(IConsole console)
        {
            _realConsole = console;
            _hybridService = new HybridService();
        }

        public float CheckMPG()
        {
            _realConsole.WriteLine("What are the miles per gallon for this hybrid?");
            var mpg = UtilMethods.ReadLineConvertToFloat();
            return mpg;
        }

        public HybridCars CreateHybrid(string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, float mpgInfo)
        {
            var hybridCar = _hybridService.CreateHybrid(make, model, year, numberOfCityMilesPerWeek,
                numberOfHighwayMilesPerWeek, mpgInfo);
            return hybridCar;
        }

        public void AddHybrid(HybridCars hybrid)
        {
            _realConsole.WriteLine("Would you like to add this car to the list?");
            _hybridService.AddHybrid(hybrid);
        }

        public static List<HybridCars> CreateHybridListForConsole()
        {
            var allHybrid = _hybridService.GetAllHybrid();
            foreach (var h in allHybrid)
            {
                _realConsole.WriteLine($"{h.Make}, {h.MilesPerGallon}");
            }

            return allHybrid;
        }

        public List<HybridCars> GetAllHybrid()
        {
            var hybridList = _hybridService.GetAllHybrid();
            return hybridList;
        }

        public HybridCars GetSingleHybridInConsole(string make, string model)
        {
            try
            {
                var h = _hybridService.Search(make, model);
                return h;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
