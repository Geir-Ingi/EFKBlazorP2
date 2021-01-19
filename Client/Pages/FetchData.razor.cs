using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EFKBlazorP2.Client.Services;
using EFKBlazorP2.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace EFKBlazorP2.Client.Pages
{
    [Authorize]
    public partial class FetchData
    {
        public List<WeatherForecast> HotForecasts { get; set; } = new List<WeatherForecast>();
        public List<WeatherForecast> ColdForecasts { get; set; } = new List<WeatherForecast>();
        [Inject]
        public HttpClient Http { get; set; }
        [Inject]
        public IStateService State { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                if(State.Forecasts == null)
                {
                    State.Forecasts = (await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast")).ToList();
                }
                HotForecasts.AddRange(State.Forecasts.Where(fc => fc.TemperatureC > 15));
                ColdForecasts.AddRange(State.Forecasts.Where(fc => fc.TemperatureC <= 15));
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
    }
}
