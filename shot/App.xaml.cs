using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace shot
{
    public partial class App : Application
    {

      public static  int a = Preferences.Get("counter", 0);
        public App()
        {
            InitializeComponent();

            var tabbetPage = new TabbedPage();

            tabbetPage.Children.Add(new Page1());
            tabbetPage.Children.Add(new Page2());

            MainPage = new TabbedPage();
            MainPage = tabbetPage;

            


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
