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
            // TODO we need to decide what value every resource will add and remove
            security.Amount += Constants.SecurityRemove;
            health.Amount += Constants.HealthRemove;
            electricity.Amount += Constants.ElectricityRemove;
            this.Food = food;
            this.Water = water;
            money.Amount += Constants.MoneyRemove;
        }

        public override void ManageResources()
        {
            Food.Amount += Constants.FoodRemove;
            Water.Amount += Constants.WaterRemove;
        }
    }
}