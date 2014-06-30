using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.ViewModels
{
    using BockWeather14.Server.Models;

    using Mobile.Forms.Services;
    using Mobile.Forms.Views;

    using Xamarin.Forms;

    public class ChooseStationViewModel : BaseViewModel
    {
        private readonly ContentPage page;

        private readonly IWeatherService weatherService;

        private Command getWeatherDataCommand;

        private bool isLoadingWeather;

        public ChooseStationViewModel(ContentPage page, IWeatherService weatherService)
        {
            this.page = page;
            this.weatherService = weatherService;
            this.SelectedId = 14;
        }

        public bool IsLoadingWeather
        {
            get
            {
                return this.isLoadingWeather;
            }
            private set
            {
                this.SetProperty(ref this.isLoadingWeather, value, "IsLoadingWeather");
            }
        }

        public Command GetWeatherDataCommand
        {
            get
            {
                return getWeatherDataCommand
                       ?? (this.getWeatherDataCommand = new Command(async () => await this.DoGetWeatherData()));
            }
        }

        private async Task DoGetWeatherData()
        {
            if (this.IsLoadingWeather)
            {
                return;
            }

            this.IsLoadingWeather = true;
            try
            {
                WeatherRecord result = await this.weatherService.GetLatestData(this.SelectedId);
                await this.page.Navigation.PushModalAsync(new WeatherRecordView(new WeatherRecordViewModel { WeatherRecord = result }));
            }
            catch (Exception ex)
            {
                this.page.DisplayAlert("Error occurred", "Unable to load weather data.", "OK", null);
            }
                
            this.IsLoadingWeather = false;
        }

        public int SelectedId { get; set; }

    }
}