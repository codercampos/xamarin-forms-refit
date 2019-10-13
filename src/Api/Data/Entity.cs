using System;
namespace Api.Data
{
    /// <summary>
    /// The entity base class for every model in this project / entity database with string as Id.
    /// </summary>
    public class Entity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsEnabled { get; set; } = true;
        public bool IsDeleted { get; set; }
    }

    /// <summary>
    /// The entity base class for every model in this project / entity database.
    /// </summary>
    /// <typeparam name="T">The type being used as Id for the Entity. E.g.: int, long, string</typeparam>
    public class Entity<T> : Entity
    {
        public new T Id { get; set; }
    }
}
