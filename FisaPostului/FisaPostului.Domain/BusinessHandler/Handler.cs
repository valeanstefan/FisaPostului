using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Repository;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.BusinessHandler.Contracts
{
    public class Handler<T, A> : IHandler<T, A> 
        where T : class, new () 
        where A:class, new()
    {
        protected IRepository<A> _repository = null;

        public Handler()
        {
            this._repository = new Repository<A>(new DatabaseContext());
        }

        public void Delete(int id)
        {
            var res = this._repository.Find(id);
            if (res != null)
            {
                this._repository.Delete(res);
            }            
        }

        public List<T> GetAll()
        {
            var res = new List<T>();

            var list = this._repository.All();

            foreach(var obj in list)
            {
                res.Add(Mapper.Map<T>(obj));
            }

            return res;
        }

        public T GetById(int id)
        {
            return Mapper.Map<T>(this._repository.Find(id));
        }

        public T Insert(T program)
        {
            var res = Mapper.Map<A>(program);
            this._repository.Insert(res);
            this._repository.SaveChanges();

            return program;
        }

        public void Update(T program)
        {

            var res = Mapper.Map<A>(program);
            this._repository.Update(res);
            this._repository.SaveChanges();            
        }
    }
}