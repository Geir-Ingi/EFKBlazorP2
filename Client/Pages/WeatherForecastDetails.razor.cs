using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFKBlazorP2.Client.Services;
using EFKBlazorP2.Shared;
using Microsoft.AspNetCore.Components;

namespace EFKBlazorP2.Client.Pages
{
    public partial class WeatherForecastDetails
    {
        [Inject]
        public IStateService State { get; set; }
        public WeatherForecast Forecast { get; set; }
        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            if(State.Forecasts == null)
            {
                // Call api
            }

            Forecast = State.Forecasts.Find(fc => fc.Id == Id);
        }
    }
}
