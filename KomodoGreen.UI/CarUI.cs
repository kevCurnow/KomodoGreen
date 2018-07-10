using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.BLL;
using KomodoGreen.Data;

namespace KomodoGreen.UI
{
    public class CarUI
    {
        private static IConsole _console;

        public CarUI(IConsole consoleForAllReadsAndWrites)
        {
            _console = consoleForAllReadsAndWrites;
        }

        public static void Run()
        {
            bool finished = false;
            do
            {
                _console.Write("Command (addcar, listcars, search, or exit): ");
                var command = _console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(command))
                {
                    finished = true;
                }
                else if (command == "addcar")
                {
                    AddCar();
                }
                else if (command == "listcars")
                {
                    ListCars();
                }
                else if (command == "search")
                {
                    Search();
                }
                else if (command == "exit")
                {
                    finished = true;
                }
            } while (!finished);
        }

        private static Cars AddCar()
        {
            try
            {
                string make = UtilMethods.ConsoleAskMake();
                string model = UtilMethods.ConsoleAskModel();
                int year = UtilMethods.ConsoleAskYear();
                float numberOfCityMiles = UtilMethods.ConsoleAskCityMiles();
                float numberOfHighwayMiles = UtilMethods.ConsoleAskHighwayMiles();

                _console.WriteLine("What kind of car do you have:\n" +
                                   "1: Gas Car\n" +
                                   "2: Hybrid Car\n" +
                                   "3: Electric Car\n");

                var choice = UtilMethods.ReadLineConvertToInt();
                float mpgInfo = GetCarMileageStats(choice);
                Cars car = CreateVehicle(choice, make, model, year, numberOfCityMiles, numberOfHighwayMiles, mpgInfo);

                return car;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static float GetCarMileageStats(int choice)
        {
            var mpgInfo = 0f;

            switch (choice)
            {
                case 1:
                    GasUI gas = new GasUI(new RealConsole());
                    mpgInfo = gas.CheckMPG();
                    break;
                case 2:
                    ElectricUI electric = new ElectricUI(new RealConsole());
                    mpgInfo = electric.CheckMPG();
                    break;
                case 3:
                    HybridUI hybrid = new HybridUI(new RealConsole());
                    mpgInfo = hybrid.CheckMPG();
                    break;
                default:
                    mpgInfo = 0.0f;
                    break;
            }

            return mpgInfo;
        }

        private static Cars CreateVehicle(int choice, string make, string model, int year, float numberOfCityMiles,
            float numberOfHighwayMiles, float mpgInfo)
        {
            Cars car = new Cars();

            switch (choice)
            {
                case 1:
                    var gasCar = new GasUI(new RealConsole());
                    GasCars gas = gasCar.CreateGas(make, model, year, numberOfCityMiles, numberOfHighwayMiles, mpgInfo);
                    gasCar.AddGas(gas);
                    car = gas;
                    break;
                case 2:
                    var electricCar = new ElectricUI(new RealConsole());
                    ElectricCars electric = electricCar.CreateElectric(make, model, year, numberOfCityMiles,
                        numberOfHighwayMiles, mpgInfo);
                    electricCar.AddElectric(electric);
                    car = electric;
                    break;
                case 3:
                    var hybridCar = new HybridUI(new RealConsole());
                    HybridCars hybrid = hybridCar.CreateHybrid(make, model, year, numberOfCityMiles,
                        numberOfHighwayMiles, mpgInfo);
                    hybridCar.AddHybrid(hybrid);
                    car = hybrid;
                    break;
                default:
                    break;
            }

            return car;
        }

    }
}

