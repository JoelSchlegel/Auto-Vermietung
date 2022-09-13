namespace CarRent.Car.Persistence
{
    using CarRent.Car.Domain;
    using CarRent.Car.Infrastructure.Persistence;
    using Microsoft.EntityFrameworkCore;

    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
            //carContext.Database.Migrate();
        }
        public void Add(Car car)
        {
            _carContext.Cars.Add(car);
        }

        public Car GetByCarNumber(string carNumber)
        {
            return _carContext.Cars.First(c => c.CarNumber == carNumber);
        }

        public Car GetById(Guid id)
        {
            var car = _carContext.Cars.Find(id);
            return car;
        }

        public void Remove(Car car)
        {
            _carContext.Cars.Remove(car);
        }

        public void Update(Car car)
        {
            _carContext.Update(car);
        }
    }
}
