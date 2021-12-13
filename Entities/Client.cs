using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA123.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        public string GetClient()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine($"Cliente: {Name}, ({BirthDate.ToString()}) - {Email}");
            return SB.ToString();
        }



    }
}
