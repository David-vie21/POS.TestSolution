using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetSingle(int Id);
        void Create(T t);
        void Delete(int Id);
    }
}
