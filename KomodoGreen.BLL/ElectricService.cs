using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Contracts;
using KomodoGreen.Data;

namespace KomodoGreen.BLL
{
    public class ElectricService : IElectricService
    {
        private List<ElectricCars> _electric;

        public ElectricService()
        {
            _electric = new List<ElectricCars>();
        }

        public ElectricCars CreateElectric(string make, string model, int year, float numberOfCityMilesPerWeek,
            float numberOfHighwayMilesPerWeek, float milesPerCharge)
        {
            return new ElectricCars(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek, milesPerCharge);
        }

        public void AddElectric(ElectricCars electric)
        {
            _electric.Add(electric);
        }

        public List<ElectricCars> GetAllElectric()
        {
            return _electric;
        }

        public ElectricCars Search(string make, string model)
        {
            var electric = new ElectricCars();
            try
            {
                foreach (var car in _electric)
                {
                    if (car.Make == make && car.Model == model)
                    {
                        electric.Make = car.Make;
                        electric.Model = car.Model;
                        electric.Year = car.Year;
                        electric.NumberOfCityMilesPerWeek = car.NumberOfCityMilesPerWeek;
                        electric.NumberOfHighwayMilesPerWeek = car.NumberOfHighwayMilesPerWeek;
                        electric.MilesPerCharge = car.MilesPerCharge;
                    }

                    if (_electric.Count == 0)
                        break;
                }
            }
            catch (Exception)
            {
                throw new Exception("Could not find electric car");
            }

            return electric;
        }

        public ElectricCars UpdateElectric(string make, string model)
        {
            throw new NotImplementedException();
        }

        public void DeleteElectric(string make, string model)
        {
            Cars car = new Cars();

            for (int i = _electric.Count - 1; i >= 0; i--)
            {
                if (car.Make == make)
                    _electric.RemoveAt(i);

                if (_electric.Count == 0)
                    break;
            }
        }
    }
}
