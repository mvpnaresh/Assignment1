using Assignment1.Implementation.Behaviors;

namespace Assignment1.Implementation.Orders
{
    public class MembershipOrder : Order
    {
        public MembershipOrder()
        {
            OrderBehaviors.Add(new MembershipBehavior());
            OrderBehaviors.Add(new EmailBehavior());
        }
    }
}
