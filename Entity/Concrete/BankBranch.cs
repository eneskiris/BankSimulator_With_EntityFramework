using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BankBranch:IEntity
    {
        public int BankBranchId { get; set; }
        public string BankBranchName { get; set; }




    }
}
