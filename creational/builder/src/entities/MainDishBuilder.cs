
using builder.src.interfaces;

namespace builder.src.entities
{
    public class MainDishBuilder: IMealBuilderProtocol
    {
        private readonly MealBox _meal = new MealBox();

        public IMealBuilderProtocol MakeMeal()
        {
            return this;
        }
        public IMealBuilderProtocol MakeBeverage()
        {
            return this;
        }
        public IMealBuilderProtocol MakeDessert()
        {
            return this;
        }
    }
}