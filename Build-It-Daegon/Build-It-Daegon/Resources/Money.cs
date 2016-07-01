namespace Build_It_Daegon.Resources
{
    using Build_It_Daegon.Interfaces;

    public class Money : Resource, IResourceable
    {
        private const int Money_Multiplier = 10;

        public Money(int initialAmount)
        {
            this.Amount = initialAmount;
        }

        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }

        public void GenerateMoney(Population people)
        {
            //Money_Multiplier may be replaced with a constant, depending on the difculty
            this.Amount += people.Amount * Money_Multiplier; 
        }
    }
}