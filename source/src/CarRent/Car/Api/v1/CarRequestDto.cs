using System.Text.Json.Serialization;

namespace CarRent.Car.Api.v1
{
    public class CarRequestDto
    {
        public string CarNumber { get; set; }
        public string Brand { get; set; }
        public string CarClass { get; set; }
        public string Type { get; set; }
    }
}
