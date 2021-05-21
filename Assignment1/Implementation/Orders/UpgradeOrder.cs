using Assignment1.Implementation.Behaviors;

namespace Assignment1.Implementation.Orders
{
    public class UpgradeOrder : Order
    {
        public UpgradeOrder()
        {
            OrderBehaviors.Add(new UpgrageBehavior());
            OrderBehaviors.Add(new EmailBehavior());
        }
    }
}
