using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Forms.Views
{
    using Mobile.Forms.ViewModels;

    using Xamarin.Forms;

    public partial class WeatherRecordView : ContentPage
    {
        public WeatherRecordView(WeatherRecordViewModel viewModel)
        {
            this.BindingContext = viewModel;
            InitializeComponent();
        }
    }
}
