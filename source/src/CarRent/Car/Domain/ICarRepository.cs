using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    //Repository Pattern
    public interface ICarRepository : IRepository<Car>
    {
        Car GetByCarNumber(string carNumber);
    }
}
