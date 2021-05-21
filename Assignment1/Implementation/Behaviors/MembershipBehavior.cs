using Assignment1.Interface;

namespace Assignment1.Implementation.Behaviors
{
    public class MembershipBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Membership Activated" ;
        }
    }
}
