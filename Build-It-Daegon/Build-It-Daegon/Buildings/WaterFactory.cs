namespace Build_It_Daegon.Buildings
{
    using Common;
    using Resources;


    class WaterFactory : Factory
    {
        private Water water;

        public WaterFactory(char letter, Position position, Color color, ref Electricity electricity, ref Water water) : base(position, color, letter)
        {
            this.water = water;
            electricity.Amount += Constants.ElectricityRemove;
        }        

        public override void ManageResources()
        {
            // value here must be tested
            water.Amount += Constants.WaterAdd;            
        }
    }
}