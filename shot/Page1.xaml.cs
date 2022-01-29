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
    public partial class Page1 : ContentPage
    {
        
        public Page1()
        {
            InitializeComponent();
            Count.Text = App.a.ToString();
        }

        private void TostUp(object sender, System.EventArgs e)
        {
            App.a++;
            Preferences.Set("counter", App.a);

            Count.Text = App.a.ToString();
        }
        private void Reset(object sender, System.EventArgs e)
        {
            App.a = 0;
            Preferences.Set("counter", App.a);
            Count.Text = App.a.ToString();
        }
    }
}