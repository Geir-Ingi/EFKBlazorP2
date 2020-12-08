using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EFKBlazorP2.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace EFKBlazorP2.Client.Pages
{
    [Authorize]
    public partial class FetchData
    {
        public WeatherForecast[] forecasts;
        [Inject]
        public HttpClient Http { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
    }
}
