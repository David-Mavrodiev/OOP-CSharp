namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Interfaces;
    using System;

    public abstract class Building : IConstructable
    {
        private int size;
        
        public Building(Position position, Color color, int size)
        {
            this.Position = position;
            this.Color = color;
            this.Size = size;
        }

        public Position Position { get; private set; }

        public Color Color { get; private set; }

        public int Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size can not be negative");
                }

                this.size = value;
            }
        }

        public abstract int ManageResources(int resource);

        public abstract void Build();

    }
}