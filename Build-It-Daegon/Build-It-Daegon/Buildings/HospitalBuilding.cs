namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class HospitalBuilding : Building
    {
        private Health health;


        public HospitalBuilding(char letter, Position position, Color color, int size, ref Health health, ref Electricity electicity)
            : base(position, color, size, letter)
        {
            this.health = health;
            electicity.Amount += Constants.ElectricityRemove;
        }

        public override void ManageResources()
        {
            health.Amount += Constants.HealthRemove;
            health.Amount += Constants.HealthAdd;
        }
    }
}