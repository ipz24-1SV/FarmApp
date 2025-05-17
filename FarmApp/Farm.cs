using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Farm
    {
        public string Name;
        public string Owner;
        public int WorkersCount;
        public double Area;
        public string Type;
        public bool HasMachines;
        public double YearIncome;

        public double GetIncomePerWorker()
        {
            return WorkersCount == 0 ? 0 : YearIncome / WorkersCount;
        }
    }
}
