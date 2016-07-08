namespace Build_It_Daegon.Buildings
{
    using Common;
    using Resources;


    class WaterFactory : Factory
    {
        private Water water;

        public WaterFactory(Position position, Color color, ref Electricity electricity, ref Water water) : base(position, color)
        {
            this.water = water;
            electricity.Amount -= 5;
        }        

        public override void ManageResources()
        {
            // value here must be tested
            water.Amount += 5;            
        }
    }
}