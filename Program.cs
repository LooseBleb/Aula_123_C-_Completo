using AULA123.Entities;
using AULA123.Entities.Enums;
using System.Collections.Generic;

namespace AULA123
{
    sealed partial class AULA123
    {
        class Program
        {
            static void Main(String[] args)
            {
                Console.WriteLine("Enter Cliente Data: ");

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Email: ");
                string Email = Console.ReadLine();

                Console.Write("Birth Date (DD/MM/YYYY) : ");
                DateTime BirthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Order Data: ");
                Console.Write("Status: ");
                OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

                Order Cliente = new Order(DateTime.Now,Status,Name,Email,BirthDate);

                Console.WriteLine("How many items to this order: ");
                int Item = int.Parse(Console.ReadLine());

                for(int i = 1; i <= Item; i++)
                {
                    Console.WriteLine($"Enter #{i} Item data");
                    Console.WriteLine("Name Product: ");
                    string ProdName = Console.ReadLine();
                    Console.WriteLine("Product Price: ");
                    double Price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantity: ");
                    int Quantity = int.Parse(Console.ReadLine());

                    Cliente.AddItem(new OrderItem(Quantity, Price, ProdName));

                }


                Console.WriteLine("-----------------------------------------------------------------");


                Console.WriteLine(Cliente.ToString());

               
                Console.ReadLine();
                
            }
        }
    }
}