using System;

namespace HW2
{
    abstract class BaseWorker : IComparable
    {
        public abstract double Rate { get; }
        public abstract double AverageMonthlyWage { get; }

        public abstract void CalcMonthlySalary();

        public abstract void SetRate(double _rate);

        public virtual int CompareTo(object obj)
        {
            var w = obj as BaseWorker;
            return this.Rate < w.Rate ? -1 : 1;
        }
    }
}
