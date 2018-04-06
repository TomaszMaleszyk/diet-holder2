using System.Collections.Generic;
using DietHolder2ClientWPF.Models;

namespace DietHolder2ClientWPF.Interfaces
{
    public interface IProductDatabaseManager
    {
        IEnumerable<IProduct> GetAll();
        Product GetSingle(int id);
        string Put();
        string Post(IProduct product);
        string Delete(int id);
    }
}
