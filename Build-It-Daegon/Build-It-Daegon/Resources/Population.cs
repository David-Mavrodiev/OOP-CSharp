using Build_It_Daegon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_It_Daegon.Resources
{
    public class Population : Resource, IResourceable
    {
        public Population(int amount)
        {
            this.Amount = amount;
        }
        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }

        public void CalculatePopulation(Happiness happy, int numberOfResidence)
        {
            this.Amount = happy.Amount * numberOfResidence;
        }
    }
}
