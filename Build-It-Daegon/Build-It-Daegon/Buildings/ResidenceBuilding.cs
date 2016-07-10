namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class ResidenceBuilding : Building
    {
        //private Security Security;
        //private Health Health;
        //private Electricity Electricity;
        private Food food;
        private Water water;
        //private Money Money;

        public ResidenceBuilding(char letter, Position position, Color color, int size, ref Security security, ref Health health, ref Electricity electricity, ref Food food, ref Water water, ref Money money)
            : base(position, color, size, letter)
        {
            // TODO we need to decide what value every resource will add and remove
            security.Amount += Constants.SecurityRemove;
            health.Amount += Constants.HealthRemove;
            electricity.Amount += Constants.ElectricityRemove;
            this.food = food;
            this.water = water;
            money.Amount += Constants.MoneyRemove;
        }

        public override void ManageResources()
        {
            food.Amount += Constants.FoodRemove;
            water.Amount += Constants.WaterRemove;
        }
    }
}