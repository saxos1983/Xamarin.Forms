using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Views
{
    using Mobile.Forms.ViewModels;

    using Xamarin.Forms;

    public class WeatherRecordView : ContentPage
    {
        private WeatherRecordViewModel viewModel;

        public WeatherRecordView()
        {
            this.viewModel = new WeatherRecordViewModel();
            this.BindingContext = this.viewModel;
            ////InitializeComponent();

            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = 
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions = 
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            grid.Children.Add(new Label { Text = this.viewModel.WeatherRecord.StationId.ToString() }, 0, 0);

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;
        }
    }
}