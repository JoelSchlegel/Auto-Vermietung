using System.Text.Json.Serialization;

namespace CarRent.Car.Api.v1
{
    public class CarResponseDto
    {
        [JsonPropertyName("car-number")]
        public Guid Id { get; set; }
        public string CarNumber { get; set; }
        public string Brand { get; set; }
        public string CarClass { get; set; }
        [JsonInclude()]
        public string Type { get; set; }
    }
}
