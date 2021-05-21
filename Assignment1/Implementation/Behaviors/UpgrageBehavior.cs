using Assignment1.Interface;

namespace Assignment1.Implementation.Behaviors
{
    public class UpgrageBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Applying Upgrade";
        }
    }
}
