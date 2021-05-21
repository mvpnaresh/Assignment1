using Assignment1.Interface;

namespace Assignment1.Implementation.Behaviors
{
    public class EmailBehavior : IOrderBehavior
    {
        public string ProcessOrder()
        {
            return $"Email Owner";
        }
    }
}
