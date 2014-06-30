using Xamarin.Forms;

namespace Mobile.Forms
{
    using Mobile.Forms.Views;

    public class App
    {
        public static Page GetMainPage()
        {
            return new ChooseStationView();
        }
    }
}
