using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_2
{
    internal class Team
    {
        private string name;
        private List<Worker> workers = new List<Worker>();
        public Team(string name) => this.name = name;
        public void AddNewWorker(Worker worker)
        {
            workers.Add(worker);
        }
        public void ShowInfoAboutTeam()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Name);
            }
        }
        public void ShowDetailInfoAboutTeam()
        {
            Console.WriteLine("Team name:" + name + "\nTeam members:");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
