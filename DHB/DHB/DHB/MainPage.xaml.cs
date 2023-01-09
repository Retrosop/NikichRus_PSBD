using System;
using Xamarin.Forms;

namespace DHB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void OpenCreator(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        

    }



}
