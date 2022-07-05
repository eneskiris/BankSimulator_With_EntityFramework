using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditManager : ICreditService
    {

        ICreditDal _creditDal;


        public CreditManager(ICreditDal creditDal)
        {
            _creditDal = creditDal;
        }

        public void Add(Credit entity)
        {
            if (entity.CreditName.Length >= 2 && entity.InterestRate >0 && entity.Maturity >= 3)
            {
                _creditDal.Add(entity);
            }
            else
            {
                throw new Exception("The Credit Could Not Be Added...");
            }
        }

        public void Delete(Credit entity)
        {
           _creditDal.Delete(entity);
        }
       
        public List<Credit> GetAll()
        {
            return _creditDal.GetAll();
        }

        public Credit GetById(int creditId)
        {
            return _creditDal.Get(c => c.CreditId == creditId);
        }

        public void Update(Credit entity)
        {
             _creditDal.Update(entity);
        }
    }
}
