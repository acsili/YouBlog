﻿namespace YouBlog.DAL.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetList();
        T Get(int id);
        void Create(T item); 
        void Update(T item); 
        void Delete(int id); 
        void Save(); 
    }
}
