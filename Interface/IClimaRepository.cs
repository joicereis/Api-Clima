using Api_Clima.Models;

namespace Api_Clima.Interface
{
    public interface IClimaRepository
    {
        Task<ClimaInfo> GetClimaAsync(string city);
    }
}
