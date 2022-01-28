using System.Collections.Generic;

namespace DIO.Series.src.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Create(T entity);
        void Destroy(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
