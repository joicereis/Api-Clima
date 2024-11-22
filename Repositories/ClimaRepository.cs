using Api_Clima.Interface;
using Api_Clima.Models;

namespace Api_Clima.Repositories
{
    public class ClimaRepository : IClimaRepository
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = ""; //Inserir aqui a chave da api
        private const string BaseUrl = "http://api.weatherapi.com/v1";

        public ClimaRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ClimaInfo> GetClimaAsync(string city)
        {
            var url = $"{BaseUrl}/current.json?key={ApiKey}&q={city}&aqi=no";
            var response = await _httpClient.GetFromJsonAsync<ClimaResponse>(url);

            if (response != null)
            {
                return new ClimaInfo
                {
                    City = response.Location.Name,
                    Region = response.Location.Region,
                    TempCelsius = response.Current.Temp_C,
                    Humidity = response.Current.Humidity,
                    Condition = response.Current.Condition.Text,
                    IconeCondicion = response.Current.Condition.Icon, 
                    WindSpeed = response.Current.Wind_Kph
                };
            }
            else
            {
                throw new Exception("Erro ao obter dados da API de clima.");
            }
        }
    }
}
