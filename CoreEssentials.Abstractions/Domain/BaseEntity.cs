namespace CoreEssentials.Abstractions.Domain
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}