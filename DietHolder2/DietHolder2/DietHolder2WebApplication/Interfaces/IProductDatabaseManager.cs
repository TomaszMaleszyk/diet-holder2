using System.Collections.Generic;
using System.Threading.Tasks;
using DietHolder2WebApplication.Repositories;

namespace DietHolder2WebApplication.Interfaces
{
    public interface IProductDatabaseManager
    {
        IEnumerable<Products> GetAll();
        Task<Products> GetSingle(int id);
        string Put();
        Task Post(Products product);
        Task Delete(int id);
    }
}
