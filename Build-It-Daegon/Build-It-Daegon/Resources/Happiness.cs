namespace Build_It_Daegon.Resources
{
    public class Happiness : Resource
    {
        private const int InitialHappiness = 80;
        private const int HalfHappiness= 50;
        private const int HappinessMultiplier = 10;

        public Happiness()
        {
            this.Amount = InitialHappiness;
        }

        public void EvaluateHappiness(Food food, Security security, Electricity electricity, Health health, Water water)
        {
            var sum = food.IsPositive() + security.IsPositive() + electricity.IsPositive() + health.IsPositive() + water.IsPositive();

            this.Amount = HalfHappiness + HalfHappiness * sum;
        }
    }
}