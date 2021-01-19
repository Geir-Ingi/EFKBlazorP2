using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFKBlazorP2.Shared;
using Microsoft.AspNetCore.Components;

namespace EFKBlazorP2.Client.Components
{
    public partial class WeatherForecastTable
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public List<WeatherForecast> Forecasts { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }

        protected void NavigeToDetails(int Id)
        {
            Navigation.NavigateTo("/details/" + Id);
        }
    }
}
