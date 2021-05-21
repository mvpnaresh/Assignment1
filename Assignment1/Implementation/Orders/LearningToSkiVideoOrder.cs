using Assignment1.Implementation.Behaviors;

namespace Assignment1.Implementation.Orders
{
    public class LearningToSkiVideoOrder : Order
    {
        public LearningToSkiVideoOrder()
        {
            OrderBehaviors.Add(new PackingSlipBehavior());
            OrderBehaviors.Add(new FirstAidVideoBehavior());
        }
    }
}
