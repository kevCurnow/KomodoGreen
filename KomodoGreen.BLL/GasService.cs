using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Contracts;
using KomodoGreen.Data;

namespace KomodoGreen.BLL
{
    public class GasService : IGasService
    {
        private List<GasCars> _gasCars;

        public GasService()
        {
            _gasCars = new List<GasCars>();
        }

        public GasCars CreateGas(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerGallon)
        {
            return new GasCars(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek, milesPerGallon);
        }

        public void AddGas(GasCars gas)
        {
            _gasCars.Add(gas);
        }

        public List<GasCars> GetAllGas()
        {
            return _gasCars;
        }
        public GasCars Search(string make, string model)
        {
            var gas = new GasCars();
            try
            {
                foreach (var car in _gasCars)
                {
                    if (car.Make == make && car.Model == model)
                    {
                        gas.Make = car.Make;
                        gas.Model = car.Model;
                        gas.Year = car.Year;
                        gas.NumberOfCityMilesPerWeek = car.NumberOfCityMilesPerWeek;
                        gas.NumberOfHighwayMilesPerWeek = car.NumberOfHighwayMilesPerWeek;
                        gas.MilesPerGallon = car.MilesPerGallon;
                    }

                    if (_gasCars.Count == 0)
                        break;
                }
            }
            catch (Exception)
            {
                throw new Exception("Could not find gas car");
            }

            return gas;
        }

        public GasCars UpdateGas(Cars car, float milesPerGallon)
        {
            throw new NotImplementedException();
        }

        public void DeleteGas(Cars car, float milesPerGallon)
        {
            throw new NotImplementedException();
        }
    }
}
