using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using MediaManager;


namespace shot
{
    public partial class MainPage : TabbedPage
    {
        
        int a = Preferences.Get("counter", 0);
        public MainPage()
        {
            InitializeComponent();
            Count.Text = App.a.ToString();
            Count2.Text = App.a.ToString();

        }

        



        private void TostUp(object sender, System.EventArgs e)
        {
            App.a++;
            Preferences.Set("counter", App.a);
            Count.Text = App.a.ToString();
            Count2.Text = App.a.ToString();

        }
        private void Reset(object sender, System.EventArgs e)
        {
            App.a = 0;
            Preferences.Set("counter", App.a);
            Count.Text = App.a.ToString();
            Count2.Text = App.a.ToString();

        }


        private int PauseCount = -1;
        async private void HelpMe(object sender, System.EventArgs e)
        {
            await CrossMediaManager.Current.Stop();
            PauseCount = -1;
        }

      

        async private void SingBaby(object sender, System.EventArgs e)
        {

            if ( CrossMediaManager.Current.IsPrepared())
            {
                await CrossMediaManager.Current.PlayPause();
                
            }
            //else if (CrossMediaManager.Current.IsPlaying())
            //{
            //    await CrossMediaManager.Current.Pause();
            //}
            else
            {
                Random rnd = new Random();

                await CrossMediaManager.Current.PlayFromAssembly(rnd.Next(1,3).ToString() + ".mp3");

            }
            

        }
        private void TostUp2(object sender, System.EventArgs e)
        {
            App.a++;
            Preferences.Set("counter", App.a);
            Count.Text = App.a.ToString();
            Count2.Text = App.a.ToString();
        }

    }







}
