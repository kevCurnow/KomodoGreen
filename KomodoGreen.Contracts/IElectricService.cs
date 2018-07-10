using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Data;

namespace KomodoGreen.Contracts
{
    public interface IElectricService
    {
        ElectricCars CreateElectric(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerCharge);
        void AddElectric(ElectricCars electric);
        List<ElectricCars> GetAllElectric();
        ElectricCars Search(string make, string model);
        ElectricCars UpdateElectric(string make, string model);
        void DeleteElectric(string make, string model);
    }
}
