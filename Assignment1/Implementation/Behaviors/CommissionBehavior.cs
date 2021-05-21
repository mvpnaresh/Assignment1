using Assignment1.Interface;

namespace Assignment1.Implementation.Behaviors
{
    public class CommissionBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Generate Commission";
        }
    }
}
