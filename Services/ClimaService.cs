using Api_Clima.Interface;
using Api_Clima.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;
using System.Text;

namespace Api_Clima.Services
{
    public class ClimaService
    {
        private readonly IClimaRepository _climaRepository;

        public ClimaService(IClimaRepository climaRepository)
        {
            _climaRepository = climaRepository;
        }

        public async Task<ClimaInfo> GetClimaAsync(string city)
        {
            string newCity = RemoverAcentosDaCidade(city);
            return await _climaRepository.GetClimaAsync(newCity);
        }

        public static string RemoverAcentosDaCidade(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return city;

            // Normaliza o texto para decompor caracteres acentuados
            var cityNormalize = city.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var caractere in cityNormalize)
            {
                // Adiciona apenas caracteres que não são marcas de diacríticos e que não estão combinados com acentos
                if (CharUnicodeInfo.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(caractere);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
