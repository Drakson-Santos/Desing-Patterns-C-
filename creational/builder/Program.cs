using System;
using builder.src.entities;
using builder.src.interfaces;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var rice = new Rice("Arroz", 5);
            var beans = new Beans("Feijao", 10);
            var meat = new Meat("Carne", 20);

            var mealBox = new MealBox();
            mealBox.Add(rice);
            mealBox.Add(beans);
            mealBox.Add(meat);
            Console.WriteLine(mealBox.GetPrice());
        }
    }
}
