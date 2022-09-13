using CarRent.Car.Api.v1;
using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class CarClass : Entity, IAggregateRoot
    {
        public string Name { get; }

        public CarClass()
        {

        }

        public CarClass(string carClass)
        {
            Name = carClass;
        }
    }
}
