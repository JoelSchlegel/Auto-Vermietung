using CarRent.Car.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarService _carService;

        public CarController(CarService carService)
        {
            _carService = carService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarResponseDto> Get()
        {
            return new CarResponseDto[] 
            {
                new CarResponseDto()
                {
                Id = Guid.NewGuid(),
                CarNumber = "XW82",
                Brand ="Audi",
                Type = "Suv",
                CarClass = "Luxury"
                } 
            };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public CarResponseDto Get(Guid id)
        {
            return _carService.GetCar(id);
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarRequestDto value)
        {
            _carService.AddCar(value);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] CarRequestDto value)
        {
            _carService.UpdateCar(value);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(CarRequestDto value)
        {
            _carService.RemoveCar(value);
        }
    }
}
