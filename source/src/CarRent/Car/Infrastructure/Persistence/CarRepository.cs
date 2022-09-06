namespace CarRent.Car.Persistence
{
    using CarRent.Car.Domain;
    using CarRent.Car.Infrastructure.Persistence;

    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Car GetByCarNumber(string carNumber)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Guid id)
        {
            var car = _carContext.Cars.Find(id);
            return car;
        }

        public void Remove(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
