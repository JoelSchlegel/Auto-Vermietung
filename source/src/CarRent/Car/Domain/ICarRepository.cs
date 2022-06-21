namespace CarRent.Car.Domain
{
    //Repository Pattern
    public interface ICarRepository
    {
        Car GetById(Guid id);
        Car GetByCarNumber(string carNumber);

        //..

        void Add(Car car);
        void Update(Car car);
        void Remove(Car car);
    }
}
