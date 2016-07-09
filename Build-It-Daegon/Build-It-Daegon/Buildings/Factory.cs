namespace Build_It_Daegon.Buildings
{
    using Common;

    public abstract class Factory : Building
    {


        public Factory(Position position, Color color)
            : base(position, color, Constants.FactorySize)
        {

        }
    }
}