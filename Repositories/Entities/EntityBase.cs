using Share.Intefaces.Entity;

namespace Repositories.Entities
{
    public class EntityBase: IEntity
    {
        public virtual int Id { get; set; }
    }
}
