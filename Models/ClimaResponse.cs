using Microsoft.OpenApi.Services;

namespace Api_Clima.Models
{
    public class ClimaResponse
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
    }

    public class Current
    {
        public double Temp_C { get; set; }
        public double Humidity { get; set; }
        public double Wind_Kph { get; set; }
        public Condition Condition { get; set; }
    }

    public class Condition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
