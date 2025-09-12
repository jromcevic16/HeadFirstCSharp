using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    public class Queen : Bee
    {
        private Bee[] workers = new Bee[0];
        private float eggs = 0;
        private float unassignedWorkers = 3;
        private const float EGGS_PER_SHIFT = 0.45f;
        private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;
        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }
        public Queen(): base("Queen")
        {
            AssignBee("Nectar Collector");
            AssignBee("Honey Manufacturer");
            AssignBee("Egg Care");
        }
        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach(Bee bee in workers)
            {
                bee.WorkTheNextShift();
            }
            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * workers.Length);
            UpdateStatusReport();
        }
        public void AssignBee(string jobName)
        {
            switch (jobName)
            {
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
                default:
                    throw new InvalidOperationException();
            }
            UpdateStatusReport();
        }
        public void CareForEggs(float eggsToConvert)
        {
            if(eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }
        private void AddWorker(Bee worker)
        {
            if(unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length-1] = worker;
            }
        }
        private string WorkerStatus(string job)
        {
            int count = 0;
            string s = "";
            foreach(Bee bee in workers)
            {
                if(bee.job == job)
                {
                    count++;
                }
            }
            if (count > 1)
                s = "s";
            return $"{count} {job} bee{s}";
        }
        public void UpdateStatusReport()
        {
            StatusReport = $"{HoneyVault.StatusReport} \n" +
                   $"Egg count: {eggs}\n" +
                   $"Unassigned workers: {unassignedWorkers}\n" +
                   $"{WorkerStatus("Nectar Collector")}\n" +
                   $"{WorkerStatus("Honey Manufacturer")}\n" +
                   $"{WorkerStatus("Egg Care")}\n"+
                   $"TOTAL WORKERS: {workers.Length}";
        }
    }
}
