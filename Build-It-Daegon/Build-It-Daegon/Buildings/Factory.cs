namespace Build_It_Daegon.Buildings
{
    using Common;

    public abstract class Factory : Building
    {
        private const int FactorySize = 2;

        public Factory(Position position, Color color) : base(position, color, FactorySize)
        {
        }
    }
}