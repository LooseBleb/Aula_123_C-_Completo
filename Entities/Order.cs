using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AULA123.Entities.Enums;

namespace AULA123.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        List<OrderItem> Items { get; set;} = new List<OrderItem>();

        public Order(DateTime moment,OrderStatus status, string name, string email, DateTime birthdate)
        {
            Moment = moment;
            Status = status;
            Client.Name = name;
            Client.Email = email;
            Client.BirthDate = birthdate;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine($"Order Moment: {Moment}");
            SB.AppendLine($"Order Status: {Status.ToString()}");
            SB.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("d")}), - {Client.Email}");
            foreach(OrderItem item in Items)
            {
               SB.AppendLine(item.ToString());
            }
            SB.AppendLine("Total Price :" + Total());
            return SB.ToString();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }
    }
}
