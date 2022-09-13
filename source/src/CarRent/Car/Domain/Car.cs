using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class Car : Entity, IAggregateRoot

    {
        //Pocos
        public string CarNumber { get; }
        public CarClass CarClass { get; }
        public Brand Brand { get; }
        public Type Type { get; }

        public Car()
        {

        }

        public Car(string carNumber, string carClass, string brand, string type)
        {
            CarNumber = carNumber;
            CarClass = new CarClass(carClass);
            Brand = new Brand(brand);
            Type = new Type(type);
        }
    }
}
