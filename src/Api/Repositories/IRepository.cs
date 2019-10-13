using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Api.Data;

namespace Api.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected static ConcurrentDictionary<string, T> Items { get; set; } = new ConcurrentDictionary<string, T>();

        public void Add(T item)
        {
            item.Id = Guid.NewGuid().ToString();
            Items[item.Id] = item;
        }

        public void Update(T item)
        {
            Items[item.Id] = item;
        }

        public T Remove(string key)
        {
            Items.TryRemove(key, out T item);
            // Returns the item deleted
            return item;
        }

        public T Get(string key)
        {
            Items.TryGetValue(key, out T item);
            // Return the item. If null, there is no item
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return Items.Values;
        }
    }

    public interface IRepository<T> where T : Entity
    {
        void Add(T item);
        void Update(T item);
        T Remove(string key);
        T Get(string key);
        IEnumerable<T> GetAll();
    }
}
