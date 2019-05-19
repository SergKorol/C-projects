using System;
using System.Collections.Generic;

namespace LibraryManagementCourseModel.Interfaces
{
    //В этом интрефейсе использован плейсхолдер, где будет подставляться имя класса
    public interface IRepository<T> where T : class
    {
        //Этот метод получит все числовые элементы по указанному классу
        IEnumerable<T> GetAll();
        //Поиск элемента
        IEnumerable<T> Find(Func<T, bool> predicate);
        //Получить id
        T GetById(int id);
        //Создать запись
        void Create(T entity);
        //Обновить
        void Update(T entity);
        //Удалить
        void Delete(T entity);
        //Подсчет количества
        int Count(Func<T, bool> predicate);
    }
}
