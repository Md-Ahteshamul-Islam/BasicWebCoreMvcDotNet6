using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Domains.Customer
{
    public class User:BaseEntity
    {
        public string Name { get; set; }   
        public string Email { get; set; }   
        public string Contact { get; set; }   
    }
}
