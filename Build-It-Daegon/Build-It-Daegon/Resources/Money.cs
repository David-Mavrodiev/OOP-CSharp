using Build_It_Daegon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_It_Daegon.Resources
{
    public class Money : Resource, IResourceable
    {
        private const int Money_Multiplier = 10;
        public Money(int initialAmount)
        {
            this.Amount = initialAmount;
        }
        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }

        public void GenerateMoney(Population people)
        {
            this.Amount += people.Amount * Money_Multiplier; //Money_Multiplier may be replaced with a constant, depending on the difculty
        }
    }
}
