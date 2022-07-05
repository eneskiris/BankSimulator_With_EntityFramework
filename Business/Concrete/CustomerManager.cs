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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer entity)
        {
            if (entity.CustomerName.Length >= 2 && entity.CustomerSurname.Length >= 2 && entity.Age >= 18)
            {
                _customerDal.Add(entity);
            }
            else
            {
                throw new Exception("The Customer Could Not Be Added..");
            }
        }

        public void Delete(Customer entity)
        {
           _customerDal.Delete(entity);

        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int customerId)
        {
            return _customerDal.Get(c => c.CustomerId == customerId);
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
