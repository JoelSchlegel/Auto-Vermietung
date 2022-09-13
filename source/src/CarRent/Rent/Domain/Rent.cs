using CarRent.Common.Domain;

namespace CarRent.Rent.Domain
{
    public class Rent : Entity, IAggregateRoot
    {
        public int Days { get; }
        public int Total { get; }
    }
}
