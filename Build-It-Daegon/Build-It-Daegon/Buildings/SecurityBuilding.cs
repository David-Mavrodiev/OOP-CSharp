namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Resources;

    public class SecurityBuilding : Building
    {
        private Security Security;

        public SecurityBuilding(Position position, Color color, int size, ref Security security, ref Electricity electricity)
            : base(position, color, size)
        {
            // TODO we need to decide what value every resource will add and remove
            this.Security = security;
            electricity.Amount += Constants.ElectricityRemove;
        }

        public override void ManageResources()
        {
            Security.Amount += Constants.SecurityAdd;
        }
    }
}