using Assignment1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Implementation
{
    public abstract class Order
    {
        public List<IOrderBehavior> OrderBehaviors = new List<IOrderBehavior>();

        public List<string> ProcessOrder()
        {
            var orderList = new List<string>();

            foreach (var item in OrderBehaviors)
            {
                orderList.Add(item.ProcessOrder());
            }
            return orderList;
        }
    }
}
