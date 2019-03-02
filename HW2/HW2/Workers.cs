using System.Collections;
using System.Collections.Generic;

namespace HW2
{
    class Workers
    {
        public Workers() => WorkersList = new List<BaseWorker>();

        public List<BaseWorker> WorkersList { get; }

        public void AddWorker(BaseWorker worker)
        {
            WorkersList.Add(worker);
        }

        public IEnumerable GetWorkers
        {
            get
            {
                for(int i = 0; i < WorkersList.Count; i++) yield return WorkersList[i];
            }
        }
    }
}
