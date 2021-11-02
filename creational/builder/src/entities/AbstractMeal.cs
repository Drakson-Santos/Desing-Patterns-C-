using builder.src.interfaces;

namespace builder.src.entities
{
    public class AbstractMeal : IMealCompositeProtocol
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public AbstractMeal(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}