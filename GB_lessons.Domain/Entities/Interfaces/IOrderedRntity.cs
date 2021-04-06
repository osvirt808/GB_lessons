namespace GB_lessons.Domain.Entities.Interfaces
{
    public interface IOrderedRntity : IEntity
    {
        int Order { get; set; }
    }
}
