using Build_It_Daegon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_It_Daegon.Resources
{
    public class Electricity : Resource, IResourceable, IValuable
    {
        public Electricity(int amount)
        {
            this.Amount = amount;
        }
        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public int IsPositive()
        {
            if (this.Amount >= 0)
            {
                return 1;
            }
            return 0;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }
    }
}
