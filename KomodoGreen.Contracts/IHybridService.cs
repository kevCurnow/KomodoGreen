using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Data;

namespace KomodoGreen.Contracts
{
    public interface IHybridService
    {
        HybridCars CreateHybrid(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerGallon);
        void AddHybrid(HybridCars hybrid);
        List<HybridCars> GetAllHybrid();
        HybridCars Search(string make, string model);
        HybridCars UpdateHybrid(string make, string model);
        void DeleteHybrid(Cars car, float milesPerGallon);
    }
}
