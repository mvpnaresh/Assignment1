using Assignment1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Implementation.Behaviors
{
    public class PackingSlipBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Generated Packing slip for shipping";
        }
    }
}
