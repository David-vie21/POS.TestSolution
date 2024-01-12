using Spg.SpengerBank.DomainModel.Interfaces;
using Spg.SpengerBank.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.Repository
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly BankContext _context;
        public Repository(BankContext context)
        {
            _context = context;     
        }
        public void Create(T t)
        {
            _context.Add(t);
        }

        public void Delete(int Id)
        {
            _context.Remove(Id);
        }

        public IQueryable<T> GetAll()
        {
            return (IQueryable<T>)_context.Set<T>().ToList<T>();
        }

        public T GetSingle(int Id)
        {
            return _context.Find<T>(Id);
        }
    }
}
