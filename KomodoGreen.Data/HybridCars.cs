using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    class HybridCars : Cars
    {
        private float _milesPerGallon;

        public float MilesPerGallon
        {
            get => _milesPerGallon;
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("Miles per gallon can't be negative!");
                }
                else
                {
                    _milesPerGallon = value;
                }
            }
        }
        public HybridCars(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerGallon) 
            : base(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek)
        {
            MilesPerGallon = milesPerGallon;
        }
    }
}
