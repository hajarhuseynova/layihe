using CodeAcademy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Data.Repositories
{ 

    internal class Repository<T> : IRepository<T>
    {

        private static List<T> _items=new List<T>();
        public List<T> Items { get { return _items; } } 

        public async Task AddAsync(T model)
        {
          Items.Add(model);
        }

        public async Task<List<T>> GetAllAsync()
        {
           return Items;    
        }

        public async Task<T> GetAsync(Func<T, bool> expression)
        {
           return Items.FirstOrDefault(expression);

        }

        public async Task RemoveAsync(T model)
        {
           Items.Remove(model); 
        }

        public async Task UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
