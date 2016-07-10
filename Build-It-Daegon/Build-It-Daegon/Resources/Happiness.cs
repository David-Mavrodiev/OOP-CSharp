using Build_It_Daegon.Common;

namespace Build_It_Daegon.Resources
{
    public class Happiness : Resource
    {

        public Happiness()
        {
            this.Amount = Constants.InitialHappiness;
        }

        public void EvaluateHappiness(Food food, Security security, Electricity electricity, Health health, Water water)
        {
            var sum = food.IsPositive() + security.IsPositive() + electricity.IsPositive() + health.IsPositive() + water.IsPositive();

            this.Amount = Constants.HalfHappiness + Constants.HappinessMultiplier * sum;
        }
    }
}