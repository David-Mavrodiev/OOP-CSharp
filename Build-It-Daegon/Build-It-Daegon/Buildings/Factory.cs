namespace Build_It_Daegon.Buildings
{
    using Common;

    public abstract class Factory : Building
    {


        public Factory(Position position, Color color, char letter)
            : base(position, color, Constants.FactorySize, letter)
        {

        }
    }
}