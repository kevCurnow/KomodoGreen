using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    public class ElectricCars : Cars
    {
        private float _milesPerCharge;
        public float MilesPerCharge
        {
            get => _milesPerCharge;
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("Miles per charge can't be negative!");
                }
                else
                {
                    _milesPerCharge = value;
                }
            }
        }
        public ElectricCars(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek, float milesPerCharge) 
            : base(make, model, year, numberOfCityMilesPerWeek, numberOfHighwayMilesPerWeek)
        {
            MilesPerCharge = milesPerCharge;
        }

        public ElectricCars()
        {

        }
    }
}
