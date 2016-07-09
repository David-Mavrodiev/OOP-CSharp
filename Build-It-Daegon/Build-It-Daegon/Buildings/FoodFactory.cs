namespace Build_It_Daegon.Buildings
{
    using Common;
    using Resources;

    class FoodFactory : Factory
    {
        private Food food;


        public FoodFactory(Position position, Color color, ref Electricity electricity, ref Food food) : base(position, color)
        {
            this.food = food;
            electricity.Amount += Constants.ElectricityRemove;
        }  
                
        public override void ManageResources()
        {
            // value here must be tested
            food.Amount += Constants.FoodAdd;
        }
    }
}