using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisaPostului.Domain.BusinessHandler.Contracts
{
    public interface IHandler<T, A> 
        where T:class, new()
        where A:class, new()
    {
        T GetById(int id);
        void Update(T program);
        void Delete(int id);
        T Insert(T program);
        List<T> GetAll();
    }
}
