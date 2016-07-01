namespace Build_It_Daegon.Buildings
{
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public abstract class Building : IConstructable
    {
        private int size;
        
        public Building(Position position, Color color, int size)
        {
            this.Position = position;
            this.Color = color;
            this.Size = size;
            
        }

        public Color Color
        {
            get
            {
                return this.Color;
            }

            set
            {
                this.Color = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.Position;
            }

            set
            {
                this.Position = value;
            }
        }

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

        public abstract void ManageResources();
    }
}