namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class ResidenceBuilding : Building
    {
        //private Security Security;
        //private Health Health;
        //private Electricity Electricity;
        private Food Food;
        private Water Water;
        //private Money Money;

        public ResidenceBuilding(Position position, Color color, int size, ref Security security, ref Health health, ref Electricity electricity, ref Food food, ref Water water, ref Money money)
            : base(position, color, size)
        {
            security.Amount -= 5;
            health.Amount -= 5;
            electricity.Amount -= 5; // 5 will be const
            this.Food = food;
            this.Water = water;
            money.Amount -= 1000; // 1000 will be const
        }

        public override void ManageResources()
        {
            Food.Amount -= 5;
            Water.Amount -= 5;
        }
    }
}