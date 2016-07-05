namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class HospitalBuilding : Building
    {
        private Health Health;
        

        public HospitalBuilding(Position position, Color color, int size, ref Health health, ref Electricity electicity) 
            : base(position, color, size)
        {
            this.Health = health;
            electicity.Amount -= 5;
        }
        
        public override void ManageResources()
        {
            // TODO we need to decide what value every resource will add and remove
            Health.Amount += 5;
        }
    }
}