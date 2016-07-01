namespace Build_It_Daegon.Interfaces
{
    using Build_It_Daegon.Common;

    public interface IConstructable
    {
        Position Position { get; }

        Color Color { get; }
    }
}