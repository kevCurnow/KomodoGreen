using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Contracts;
using KomodoGreen.Data;

namespace KomodoGreen.BLL
{
    class CarService : ICarService
    {
        private List<Cars> _carList;

        public CarService()
        {
            _carList = new List<Cars>();
        }

        public IEnumerable<Cars> GetAllCarsOfAllTypes()
        {
            throw new NotImplementedException();
        }
    }
}
