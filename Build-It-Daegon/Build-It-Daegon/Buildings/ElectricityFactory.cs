namespace Build_It_Daegon.Buildings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common;

    class ElectricityFactory : Factory
    {
        // constructor
        public ElectricityFactory(Position position, Color color) : base(position, color)
        {
        }

        // method
        public override int ManageResources(int resource)
        {
            throw new NotImplementedException();
        }

        public override void Build()
        {
            throw new NotImplementedException();
        }
    }
}
