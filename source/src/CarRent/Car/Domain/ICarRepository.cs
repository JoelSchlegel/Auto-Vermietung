using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    //Repository Pattern
    public interface ICarRepository : IRepository<Car>
    {
        Car GetById(Guid id);
        Car GetByCarNumber(string carNumber);

        //..

        void Add(Car car);
        void Update(Car car);
        void Remove(Car car);
    }
}
