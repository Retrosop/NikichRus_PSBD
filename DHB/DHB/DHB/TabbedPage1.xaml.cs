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
            BindingContext= new Heroes();
            stopwatch = new Stopwatch();
            stopwatch.Reset();
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeroClass_header.Text = "Вы выбрали класс: " + picker.Items[picker.SelectedIndex];
            result_Class.Text = "Вы выбрали класс: " + picker.Items[picker.SelectedIndex];
            result_Class.TextColor= Color.Black;
            string a = picker.SelectedItem.ToString();

            MonkSL.IsVisible= false;
            WarriorSL.IsVisible = false;
            RogueSL.IsVisible = false;
            BarbarianSL.IsVisible = false;

            if (picker.SelectedIndex == 0)
            {
                WarriorSL.IsVisible = true;
            }
            if (picker.SelectedIndex == 1)
            {
                RogueSL.IsVisible = true;
            }
            if (picker.SelectedIndex == 2)
            {
                MonkSL.IsVisible = true;
            }
            if (picker.SelectedIndex == 3)
            {
                BarbarianSL.IsVisible = true;
            }
            if (picker.SelectedIndex == 12)
            {
                
            }


        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void BattleStylePickerW_BattleStylePickerW(object sender, EventArgs e)
        {
            BSDeffense.IsVisible = false;
            BSProtection.IsVisible = false;
            BSTwoWeaponFight.IsVisible = false;
            BSGreateWeapon.IsVisible = false;
            BSDuel.IsVisible = false;
            BSShooting.IsVisible = false;
            string b = BSPickW.SelectedItem.ToString();
            
            if (BSPickW.SelectedIndex == 0)
            {
                BSDeffense.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 1) 
            { 
                BSProtection.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 2)
            {
                BSGreateWeapon.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 3)
            {
                BSTwoWeaponFight.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 4)
            {
                BSShooting.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 5)
            {
                BSDuel.IsVisible = true;
            }

        }

        private void RacePick_SelectedIndexChanged(object sender, EventArgs e)
        {
            result_Race.Text = "Вы выбрали рассу: " + RacePick.Items[RacePick.SelectedIndex];
            result_Race.TextColor = Color.Black;

        }

        private void HeroName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Result_Name.Text = HeroName.Text;
        }
        //таймер
        private void sdV_start(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    tamtx.Text = stopwatch.Elapsed.ToString());
                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                });
            }
        }
        private void sdV_stop(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }
        private void sdV_Reset(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }


        //
        private void WWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void BattleWeapon2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            WeaponWar2.IsVisible = false;
            ShildAndWeaponSL.IsVisible = false;
            if (BattleWeapon2.IsChecked == true)
            {
                WeaponWar2.IsVisible= true;
            }
            else
            {
                ShildAndWeaponSL.IsVisible = true;
            }
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

        

        

        

    }
}







