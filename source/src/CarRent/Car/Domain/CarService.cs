using CarRent.Car.Api.v1;

namespace CarRent.Car.Domain
{
    public class CarService
    {
        ICarRepository _repository;

        public CarService(ICarRepository carRepository)
        {
            _repository = carRepository;
        }

        public CarResponseDto GetCar(Guid id)
        {
            Car car = _repository.GetById(id);


            CarResponseDto carResponse = new CarResponseDto();
            carResponse.Id = car.Id;
            carResponse.CarNumber = car.CarNumber;
            carResponse.CarClass = car.CarClass.Name;
            carResponse.Brand = car.Brand.Name;
            carResponse.Type = car.Type.Name;

            return carResponse;
        }

        public void AddCar(CarRequestDto carRequest)
        {
            Car car = new Car(carRequest.CarNumber, carRequest.CarClass, carRequest.Brand, carRequest.Type);

            _repository.Add(car);
        }

        public void UpdateCar(CarRequestDto carRequest)
        {
            Car car = new Car(carRequest.CarNumber, carRequest.CarClass, carRequest.Brand, carRequest.Type);

            _repository.Update(car);
        }

        public void RemoveCar(CarRequestDto carRequest)
        {
            Car car = new Car(carRequest.CarNumber, carRequest.CarClass, carRequest.Brand, carRequest.Type);

            _repository.Remove(car);
        }
    }
}
