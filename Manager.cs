using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_2
{
    internal class Manager : Worker
    {
        private Random random = new Random();
        public Manager(string name) : base(name)
        {
            base.Position = "Manager";
        }

        public override void FillWorkDay()
        {
            for (int i = 0; i < random.Next(11); i++)
            {
                base.Call();
            }
            Relax();
            for (int i = 0; i < random.Next(6); i++)
            {
                base.Call();
            }
        }
    }
}
