namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class SecurityBuilding : Building
    {
        public SecurityBuilding(Position position, Color color, int size, ref Security security, ref Electricity electricity) 
            : base(position, color, size)
        {
        }

        public override void ManageResources()
        {
        }
    }
}