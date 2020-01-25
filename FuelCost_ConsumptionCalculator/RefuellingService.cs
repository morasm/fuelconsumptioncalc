using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost_ConsumptionCalculator
{
    class RefuellingService : IDataService<Refuelling>
    {
        private readonly Refuelling refuelDBModel = new Refuelling();

        public RefuellingService() { }

        public List<Refuelling> GetAllByMonth(int month)
        {
            using (FuelCalcEntities fce = new FuelCalcEntities()) {

                var _refuels = fce.Refuelling;
                var result = _refuels.Include(c => c.Car).Where(u => u.DateRefuel.Month == month).ToList();

                return result;
            }
        }
    }
}
