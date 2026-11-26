using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicToData
{
    public interface IRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Прочитать список сущностей типа T из базы данных
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> ReadAll();
        /// <summary>
        /// Прочитать сущность типа T из быза данных по параметру id
        /// </summary>
        /// <param name="id">Id искомой сущности</param>
        /// <returns></returns>
        T ReadById(int id);
        /// <summary>
        /// Добавить сущность типа T в базу данных
        /// </summary>
        /// <param name="item">Сущность</param>
        void Add(T item);
        /// <summary>
        /// Обновить сущность типа T в базы данных
        /// </summary>
        /// <param name="item">Сущность</param>
        void Update(T item);
        /// <summary>
        /// Удалить сущность из базы данных по её id
        /// </summary>
        /// <param name="id">Id сущности</param>
        void Delete(int id);
        /// <summary>
        /// Счетчик сущностей типа T
        /// </summary>
        /// <returns></returns>
        int Count();
    }
}
