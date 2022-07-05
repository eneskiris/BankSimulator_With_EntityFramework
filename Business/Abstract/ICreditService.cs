using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditService
    {
        List<Credit> GetAll();
        Credit GetById(int creditId);

        void Add(Credit entity);
        void Update(Credit entity);
        void Delete(Credit entity);



    }
}
