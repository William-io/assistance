using System.ComponentModel.DataAnnotations;

namespace Assistance.Domain.Models
{
    public abstract class Entity 
    {
        public int Id { get; set; }
        //protected Entity()
        //{
        //    Id = Guid.NewGuid();
        //}

        //public Guid Id { get; set; }

        //public bool Equals(Entity other)
        //{
        //    return Id == other.Id;
        //}
    }
}
