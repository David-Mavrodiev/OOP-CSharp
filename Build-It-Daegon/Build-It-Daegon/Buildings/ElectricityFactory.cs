﻿namespace Build_It_Daegon.Buildings
{
    using Common;
    using Resources;

    class ElectricityFactory : Factory
    {
        private Electricity electricity;


        public ElectricityFactory(Position position, Color color, ref Electricity electricity) : base(position, color)
        {
            this.electricity = electricity;
        }

        public override void ManageResources()
        {
            // value here must be tested
            electricity.Amount += 10;
        }        
    }
}