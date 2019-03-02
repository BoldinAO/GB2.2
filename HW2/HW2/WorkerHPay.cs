using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class WorkerHPay : BaseWorker
    {
        private double rate;

        private double averageMonthlyWage;

        public override double Rate => rate;

        public override double AverageMonthlyWage => averageMonthlyWage;

        public WorkerHPay(int _rate)
        {
            rate = _rate;
        }

        public WorkerHPay() { }

        public override void CalcMonthlySalary()
        {
            averageMonthlyWage = rate != 0.0D ? 20.8 * 8 * rate : averageMonthlyWage;
        }

        public override void SetRate(double _rate)
        {
            rate = _rate;
        }
    }
}
