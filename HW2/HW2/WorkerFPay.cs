using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class WorkerFPay : BaseWorker
    {
        private double rate;

        public override double Rate => rate;

        private double averageMonthlyWage;

        public override double AverageMonthlyWage => rate;

        public WorkerFPay(double _rate)
        {
            rate = _rate;
        }

        public WorkerFPay() { }

        public override void CalcMonthlySalary()
        {
            averageMonthlyWage = 0.0D;
        }

        public override void SetRate(double _rate)
        {
            rate = _rate;
        }
    }
}
