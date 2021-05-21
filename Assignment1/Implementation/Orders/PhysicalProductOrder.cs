using Assignment1.Implementation.Behaviors;

namespace Assignment1.Implementation.Orders
{
    public class PhysicalProductOrder : Order
    {
        public PhysicalProductOrder()
        {
            OrderBehaviors.Add(new PackingSlipBehavior());
            OrderBehaviors.Add(new CommissionBehavior());
        }
    }
}
