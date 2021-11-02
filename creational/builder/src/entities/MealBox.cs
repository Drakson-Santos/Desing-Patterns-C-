using builder.src.interfaces;
using System;
using System.Collections.Generic;

namespace builder.src.entities
{
    public class MealBox : IMealCompositeProtocol
    {
        private List<IMealCompositeProtocol> _children = new List<IMealCompositeProtocol>(new IMealCompositeProtocol[20]);
        public double GetPrice()
        {
            double totalPrice = 0;
            foreach (var item in _children)
            {
                if (item != null)
                {
                    totalPrice += item.GetPrice();
                }
            }
            return totalPrice;
        }
        public void Add(IMealCompositeProtocol item)
        {
            _children.Add(item);
        }
    }
}