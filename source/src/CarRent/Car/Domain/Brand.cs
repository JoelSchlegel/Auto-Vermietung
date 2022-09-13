using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Brand : Entity
    {
        public string Name { get;}

        public Brand()
        {

        }

        public Brand(string brand)
        {
            Name = brand;
        }
    }
}
