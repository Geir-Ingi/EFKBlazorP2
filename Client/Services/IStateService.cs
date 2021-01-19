using System.Collections.Generic;
using EFKBlazorP2.Shared;

namespace EFKBlazorP2.Client.Services
{
    public interface IStateService
    {
        int Counter { get; set; }
        List<WeatherForecast> Forecasts { get; set; }
    }
}