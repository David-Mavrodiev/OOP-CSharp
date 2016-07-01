using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_It_Daegon.Common;
using Build_It_Daegon.Resources;

namespace Build_It_Daegon.Buildings
{
    public class SecurityBuilding : Building
    {
        public SecurityBuilding(Position position, Color color, int size, ref Security security, ref Electricity electricity) : base(position, color, size)
        {
        }

        public override void ManageResources()
        {
        }
    }
}
