using OrderTech.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTech.Entities
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus  status { get; set; }

        public Client client { get; set; } = new Client();

        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in orderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }

    }
}
