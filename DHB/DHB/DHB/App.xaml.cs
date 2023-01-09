using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DHB
{
    public partial class App : Application
    {
        public App()
        {
            
            MainPage = new NavigationPage(new DHB.MainPage());
        }


    }
}
