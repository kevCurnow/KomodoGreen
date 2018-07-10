using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.UI
{
    public class UtilMethods
    {
        public static string ConsoleAskMake()
        {
            Console.WriteLine("What is the make of your car?");

            string make = Console.ReadLine();

            return make;
        }

        public static string ConsoleAskModel()
        {
            Console.WriteLine("What is the model of your car?");

            string model = Console.ReadLine();

            return model;
        }

        public static int ConsoleAskYear()
        {
            Console.WriteLine("What is the year of your car?");
            int year = ReadLineConvertToInt();
            return year;
        }

        public static float ConsoleAskCityMiles()
        {
            Console.WriteLine("What is the average city miles?");
            float cityMiles = ReadLineConvertToFloat();
            return cityMiles;
        }

        public static float ConsoleAskHighwayMiles()
        {
            Console.WriteLine("What is the average highway miles?");
            float highwayMiles = ReadLineConvertToFloat();
            return highwayMiles;
        }

        public static float ReadLineConvertToFloat()
        {
            string someNum = Console.ReadLine();
            var convertedNum = float.Parse(someNum);
            return convertedNum;
        }

        public static int ReadLineConvertToInt()
        {
            string someNum = Console.ReadLine();
            int convertedNum = Int32.Parse(someNum);
            return convertedNum;
        }
    }
}
