using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Data;

namespace KomodoGreen.Contracts
{
    public interface IGasService
    {
        GasCars CreateGas(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerGallon);
        void AddGas(GasCars gas);
        List<GasCars> GetAllGas();
        GasCars Search(string make, string model);
        GasCars UpdateGas(Cars car, float milesPerGallon);
        void DeleteGas(Cars car, float milesPerGallon);
    }
}
