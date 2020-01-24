using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost_ConsumptionCalculator
{
    interface IDataService<T>
    {
        //T GetDataById(int id);

        List<T> GetAllByMonth(int month);
    }
}
