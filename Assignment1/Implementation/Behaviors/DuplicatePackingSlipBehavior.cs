using Assignment1.Interface;

namespace Assignment1.Implementation.Behaviors
{
    public class DuplicatePackingSlipBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Duplicate packing slip created";
        }
    }
}
