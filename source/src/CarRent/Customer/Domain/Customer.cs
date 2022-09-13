using CarRent.Common.Domain;

namespace CarRent.Customer.Domain
{
    public class Customer : Entity, IAggregateRoot
    {
        public string Name { get; }
        public Address address { get; }
    }
}
