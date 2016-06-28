namespace Build_It_Daegon.Buildings
{

    using System;

    public abstract class Building : IResourceable
    {
        private Position position;
        private Color color;
        private int size;

        public Building(Position position, Color color, int size)
        {
            this.Position = position;
            this.Color = color;
            this.Size = size;
        }

        public Position Position
        {
            get { return this.position; }
            private set { this.position = value; }
        }

        public Color Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public int Size
        {
            get { return this.size; }
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

    }
}