namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class HospitalBuilding : Building
    {
        public HospitalBuilding(Position position, Color color, int size, ref Health health, ref Electricity electicity) 
            : base(position, color, size)
        {
        }
        
        public override void ManageResources()
        {
        }
    }
}