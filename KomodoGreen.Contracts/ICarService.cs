using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoGreen.Data;

namespace KomodoGreen.Contracts
{
    public interface ICarService
    {
        IEnumerable<Cars> GetAllCarsOfAllTypes();
    }
}
