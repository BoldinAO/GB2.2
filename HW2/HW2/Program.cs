using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new BaseWorker[10];
            var listWorkers = new Workers();
            Random random = new Random();

            for (int i = 0; i < workers.Length / 2; i++)
            {
                workers[i] = new WorkerHPay();
                workers[i].SetRate(double.Parse($"{random.Next(0, 9)},{random.Next(0, 9)}"));
                workers[i].CalcMonthlySalary();
                listWorkers.AddWorker(workers[i]);
            }

            for (int i = 5; i < workers.Length; i++)
            {
                workers[i] = new WorkerFPay();
                workers[i].SetRate(double.Parse($"{random.Next(0, 9)},{random.Next(0, 9)}"));
                workers[i].CalcMonthlySalary();
                listWorkers.AddWorker(workers[i]);
            }

            Console.WriteLine("Before sort");
            foreach (BaseWorker worker in workers)
                Console.WriteLine(worker.Rate);
            Console.WriteLine("_______\nAfter sort");

            Array.Sort(workers);

            foreach(BaseWorker worker in workers)
                Console.WriteLine(worker.Rate);
            Console.WriteLine("_______");

            foreach(BaseWorker worker in listWorkers.GetWorkers)
                Console.WriteLine($"{worker.Rate}  |  {worker.AverageMonthlyWage}");
        }
    }
}
