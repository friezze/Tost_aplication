using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace shot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

       
        public Page2()
        {
            InitializeComponent();
            Count2.Text = App.a.ToString();
        }

        private void HelpMe(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Ska";
            button.BackgroundColor = Color.Red;
        }
        private void SingBaby(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Ska";
            button.BackgroundColor = Color.Red;
        }
        private void TostUp2(object sender, System.EventArgs e)
        {
            App.a++;
            Preferences.Set("counter", App.a);

            Count2.Text = App.a.ToString();
        }
    }
}