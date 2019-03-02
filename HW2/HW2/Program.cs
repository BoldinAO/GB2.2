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

            for (int i = 0; i < 10; i++)
            {
                workers[i] = new WorkerHPay();
                workers[i].SetRate(double.Parse($"{random.Next(0, 9)},{random.Next(0, 9)}"));
                workers[i].CalcMonthlySalary();
                listWorkers.AddWorker(workers[i]);
            }

            foreach (BaseWorker worker in workers)
                Console.WriteLine(worker.Rate);
            Console.WriteLine("_______");

            Array.Sort(workers);

            foreach(BaseWorker worker in workers)
                Console.WriteLine(worker.Rate);
            Console.WriteLine("_______");

            foreach(BaseWorker worker in listWorkers.GetWorkers)
                Console.WriteLine($"{worker.Rate}  |  {worker.AverageMonthlyWage}");
        }
    }
}
