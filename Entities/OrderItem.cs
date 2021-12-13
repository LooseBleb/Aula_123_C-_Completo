using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA123.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        List<Product> Products { get; set; } = new List<Product>();

        public OrderItem(int quantity, double price, string name)
        {
            this.Quantity = quantity;
            this.Price = price;
            Products.Add(new Product(name,price));
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            foreach (Product product in Products)
            {
               return $"{product.ToString()} Quantity: {Quantity}, Subtotal: {SubTotal()}";
            }

            return "Order Nothing Items";
        }
    }
}
