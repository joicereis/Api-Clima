namespace Api_Clima.Models
{
    public class ClimaInfo
    {
        public string City { get; set; }
        public string Region{ get; set; }
        public double TempCelsius { get; set; }
        public double Humidity { get; set; }
        public string Condition { get; set; }
        public string IconeCondicion { get; set; }
        public double WindSpeed { get; set; }
    }
}
