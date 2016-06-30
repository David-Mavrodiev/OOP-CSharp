namespace Build_It_Daegon.Buildings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common;

    public abstract class Factory : Building
    {
        private const int SIZE = 2;

        // constructor
        public Factory(Position position, Color color) : base(position, color, SIZE)
        {
        }
    }
}
