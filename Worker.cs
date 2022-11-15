using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_2
{
    internal abstract class Worker
    {
        private string name;
        private string position;
        private string workDay;

        public Worker(string name) => this.name = name;
        public void Call()
        {
            Console.WriteLine("Calling...");
        }
        public void WriteCode()
        {
            Console.WriteLine("Writing a code...");
        }
        public void Relax()
        {
            Console.WriteLine("Relaxing...");
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string WorkDay
        {
            get { return this.workDay; }
            set { this.workDay = value; }
        }
        public string ToString()
        {
            return name + "-" + position + "-" + workDay;
        }
        public abstract void FillWorkDay();
    }
}
