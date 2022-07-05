using Core.Entities;

namespace Entities.Concrete
{
    public class Credit:IEntity
    {
        public int CreditId { get; set; }
        public string CreditName { get; set; }
        public double InterestRate { get; set; }
        public int Maturity { get; set; }




    }
}