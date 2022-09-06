using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Car : Entity, IAggregateRoot

    {
        //Pocos
        public string CarNumber { get; }
        public Brand Brand { get; }
        public Type Type { get; }
    }
}
