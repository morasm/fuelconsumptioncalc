using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost_ConsumptionCalculator
{
    class TravelService : IDataService<Travel>
    {
        private readonly Travel travelDBModel = new Travel();

        public TravelService() { }

        public List<Travel> GetAllByMonth(int month)
        {
            using (FuelCalcEntities fce = new FuelCalcEntities()) {

                var _travels = fce.Travel;
                var result = _travels.Include(us => us.User).Where(u => u.DateTravel.Month == month).ToList();

                return result;
            }
        }
    }
}
