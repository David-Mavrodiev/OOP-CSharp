namespace Build_It_Daegon.Enemy
{
    using Build_It_Daegon.Buildings;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    class EnemyBuilding : Building
    {
        private Food Food;
        private Water Water;

        public EnemyBuilding(Position position, Color color, int size, ref Security security, ref Health health, ref Electricity electricity, ref Food food, ref Water water, ref Money money)
            : base(position, color, size)
        {
            // TODO we need to decide what value every resource will add and remove
            security.Amount -= 20;
            health.Amount -= 10;
            electricity.Amount -= 15;
            this.Food = food;
            this.Water = water;
            money.Amount -= 2000;
        }

        public override void ManageResources()
        {
            Food.Amount -= 8;
            Water.Amount -= 8;
        }
    }
}
