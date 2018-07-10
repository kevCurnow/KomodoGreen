using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Contracts;
using KomodoGreen.Data;

namespace KomodoGreen.BLL
{
    public class HybridService : IHybridService
    {
        private List<HybridCars> _hybrid;

        public HybridService()
        {
            _hybrid = new List<HybridCars>();
        }
        public HybridCars CreateHybrid(string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, float milesPerGallon)
        {
            return new HybridCars(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek, milesPerGallon);
        }

        public void AddHybrid(HybridCars hybrid)
        {
            _hybrid.Add(hybrid);
        }

        public List<HybridCars> GetAllHybrid()
        {
            return _hybrid;
        }

        public HybridCars Search(string make, string model)
        {
            var hybrid = new HybridCars();
            try
            {
                foreach (var car in _hybrid)
                {
                    if (car.Make == make && car.Model == model)
                    {
                        hybrid.Make = car.Make;
                        hybrid.Model = car.Model;
                        hybrid.Year = car.Year;
                        hybrid.NumberOfCityMilesPerWeek = car.NumberOfCityMilesPerWeek;
                        hybrid.NumberOfHighwayMilesPerWeek = car.NumberOfHighwayMilesPerWeek;
                        hybrid.MilesPerGallon = car.MilesPerGallon;
                    }

                    if (_hybrid.Count == 0)
                        break;
                }
            }
            catch (Exception)
            {
                throw new Exception("Could not find hybrid car");
            }

            return hybrid;
        }

        public HybridCars UpdateHybrid(string make, string model)
        {
            throw new NotImplementedException();
        }

        public void DeleteHybrid(Cars car, float milesPerGallon)
        {
            throw new NotImplementedException();
        }
    }
}
