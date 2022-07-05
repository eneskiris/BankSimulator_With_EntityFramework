using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int Money { get; set; }
        public string NationalityId { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        List<Credit> CustomerCredit = new List<Credit>();
    }
}
