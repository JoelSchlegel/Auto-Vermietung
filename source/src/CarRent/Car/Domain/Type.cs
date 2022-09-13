using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Type : Entity
    {
        public string Name { get; }

        public Type()
        {

        }

        public Type(string type)
        {
            Name = type;
        }
    }
}
