using Assignment1.Implementation.Behaviors;

namespace Assignment1.Implementation.Orders
{
    public class BookOrder : Order
    {
        public BookOrder()
        {
            OrderBehaviors.Add(new DuplicatePackingSlipBehavior());
            OrderBehaviors.Add(new CommissionBehavior());
        }
    }
}
