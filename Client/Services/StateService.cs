using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFKBlazorP2.Shared;

namespace EFKBlazorP2.Client.Services
{
    public class StateService : IStateService
    {
        public int Counter { get; set; }
        public List<WeatherForecast> Forecasts { get; set; }
    }
}
