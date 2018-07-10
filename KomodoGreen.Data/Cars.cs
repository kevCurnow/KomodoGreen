using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.Data
{
    public class Cars
    {
        public Cars(string make, string model, int year, float numberOfCityMilesPerWeek, float numberOfHighwayMilesPerWeek)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfCityMilesPerWeek = numberOfCityMilesPerWeek;
            NumberOfHighwayMilesPerWeek = numberOfHighwayMilesPerWeek;
        }

        public Cars()
        {

        }

        private string _make;
        public string Make
        {
            get => _make;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Make cannot be empty");
                }
                else
                {
                    _make = value;
                }
            }
        }

        private string _model;

        public string Model
        {
            get => _make;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model cannot be empty");
                }
                else
                {
                    _model = value;
                }
            }
        }

        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (value < 1885)
                {
                    throw new ArgumentOutOfRangeException("The first automobile wasn't invented until 1885!");
                }
                else
                {
                    _year = value;
                }
            }
        }

        private float _numberOfCityMilesPerWeek;
        public float NumberOfCityMilesPerWeek
        {
            get => _numberOfCityMilesPerWeek;
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("You can't drive negative miles");
                }
                else
                {
                    _numberOfCityMilesPerWeek = value;
                }
            }
        }

        private float _numberOfHighwayMilesPerWeek;
        public float NumberOfHighwayMilesPerWeek
        {
            get => _numberOfHighwayMilesPerWeek;
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("You can't drive negative miles");
                }
                else
                {
                    _numberOfHighwayMilesPerWeek = value;
                }
            }
        }
    }
}
