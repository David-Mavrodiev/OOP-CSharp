namespace Build_It_Daegon.Resources
{
    public class Happiness : Resource
    {
        private const int Initial_Happiness = 80;
        private const int Half_Happiness= 50;
        private const int Happiness_Multiplier = 10;

        public Happiness()
        {
            this.Amount = Initial_Happiness;
        }

        public void EvaluateHappiness(Food food, Security security, Electricity electricity, Health health, Water water)
        {
            var sum = 0;

            sum = food.IsPositive() + security.IsPositive() + electricity.IsPositive() + health.IsPositive() + water.IsPositive();

            this.Amount = Half_Happiness + Half_Happiness * sum;
        }
    }
}