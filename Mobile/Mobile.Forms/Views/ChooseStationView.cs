namespace Mobile.Forms.Views
{
    using Mobile.Forms.Services;
    using Mobile.Forms.ViewModels;

    using Xamarin.Forms;

    public class ChooseStationView : ContentPage
    {
        private ChooseStationViewModel viewModel;

        public ChooseStationView()
        {
            this.viewModel = new ChooseStationViewModel(this, new WeatherService(new JsonToWeatherData()));
            this.BindingContext = this.viewModel;

            StackLayout stackLayout = new StackLayout { Spacing = 10 };

            stackLayout.Children.Add(
                new Label
                {
                    Text = "MeteoRitenSchauer",
                    Font = Font.BoldSystemFontOfSize(40),
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                });

            stackLayout.Children.Add(new Image { Source = "Meteor.png", Aspect = Aspect.AspectFit });

            stackLayout.Children.Add(
                new Label
                {
                    Text = "Station ID:",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start
                });

            stackLayout.Children.Add(new Entry { Text = this.viewModel.SelectedId.ToString(), Keyboard = Keyboard.Numeric, });

            ActivityIndicator activityIndicator = new ActivityIndicator { IsEnabled = true, Color = Color.Blue };
            activityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, "IsLoadingWeather");
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, "IsLoadingWeather");
            stackLayout.Children.Add(activityIndicator);

            stackLayout.Children.Add(new Button { Text = "Get Weather Data", Command = this.viewModel.GetWeatherDataCommand });

            this.Content = stackLayout;
        }
    }
}
