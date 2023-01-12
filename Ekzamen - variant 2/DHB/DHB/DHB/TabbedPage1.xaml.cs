using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DHB.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace DHB
{


    public partial class TabbedPage1 : TabbedPage
    {

        Stopwatch stopwatch;


        public TabbedPage1()
        {
            InitializeComponent();
            BindingContext = new Heroes();
            stopwatch = new Stopwatch();
            stopwatch.Reset();
        }
       

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

       

        private void HeroName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        
        private void WWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        

        private void shieldAndBattleWeapon_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void WWeapon2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void HSave_Clicked(object sender, EventArgs e)
        {
            Heroes heroes = (Heroes)BindingContext;

            if (!string.IsNullOrEmpty(heroes.Name))
            {
                await MainPage.HeroesDB.SaveHeroesAsync(heroes);
            }
            // await Shell.Current.GoToAsync("..");
            await Navigation.PopToRootAsync();


        }

        private void HSave_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}







