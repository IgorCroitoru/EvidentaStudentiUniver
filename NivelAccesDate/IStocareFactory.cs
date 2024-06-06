using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;
namespace NivelAccesDate
{
    internal interface IStocareFactory<T>
    {
        bool CreateOne(T obj);
        List<T> GetAll();
        T GetOneById(int id);
        bool UpdateOne(T entity);
        bool DeleteOne(int id);
        List<string> GetDistinct(string distinct);
    }
}
