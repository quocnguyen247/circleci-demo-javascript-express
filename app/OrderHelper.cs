using System.Linq;

namespace OrderSystem
{
    public class OrderHelper
    {
        public static double Cost(Order order)
        {
            return order.Items.Sum(i => i.Price * i.Quantity);
        }
    }
}