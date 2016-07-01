namespace Build_It_Daegon.Resources
{
    using Build_It_Daegon.Interfaces;

    public class Population : Resource, IResourceable
    {
        public Population(int amount)
        {
            this.Amount = amount;
        }

        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }

        public void CalculatePopulation(Happiness happy, int numberOfResidence)
        {
            this.Amount = happy.Amount * numberOfResidence;
        }
    }
}