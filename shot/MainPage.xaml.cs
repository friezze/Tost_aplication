using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace shot
{
    public partial class MainPage : TabbedPage
    {
        
        int a = Preferences.Get("counter", 0);
        public MainPage()
        {
            InitializeComponent();
      
        }

        //private void Button_Click1(object sender, EventArgs e)
        //{
        //    
        //    a++;

        //    TostCounter.Text = a.ToString();
        //    Preferences.Set("counter", a);
        //}

        //private void Button_Click2(object sender, EventArgs e)
        //{
        //    a = 0;
        //    TostCounter.Text = a.ToString();
        //    Preferences.Set("counter", a);
        //}
     
    }
}
