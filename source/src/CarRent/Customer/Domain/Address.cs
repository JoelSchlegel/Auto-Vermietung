using CarRent.Common.Domain;

namespace CarRent.Customer.Domain
{
    public class Address : Entity
    {
        public string Street { get; }
        public int PostalCode { get; }
    }
}
