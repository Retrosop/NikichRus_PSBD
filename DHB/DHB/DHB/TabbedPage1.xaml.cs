using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            stopwatch = new Stopwatch();
            stopwatch.Reset();
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeroClass_header.Text = "Вы выбрали класс: " + picker.Items[picker.SelectedIndex];
            result_Class.Text = "Вы выбрали класс: " + picker.Items[picker.SelectedIndex];
            result_Class.TextColor= Color.Black;
            string a = picker.SelectedItem.ToString();

            if (picker.SelectedIndex == 0)
            {
                WarriorSL.IsVisible = true;
                RogueSL.IsVisible = false;

            }

            if (picker.SelectedIndex == 1)
            {
                WarriorSL.IsVisible = false;
                RogueSL.IsVisible = true;
            }
            if (picker.SelectedIndex == 2)
            {
                
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
            
            string b = BSPickW.SelectedItem.ToString();
            
            if (BSPickW.SelectedIndex == 0)
            {
                BSDeffense.IsVisible = true;
                BSProtection.IsVisible = false;
                BSTwoWeaponFight.IsVisible = false;
                BSGreateWeapon.IsVisible = false;
                BSDuel.IsVisible = false;
                BSShooting.IsVisible = false;
            }

            if (BSPickW.SelectedIndex == 1)
            {
                BSDeffense.IsVisible = false;
                BSProtection.IsVisible = true;
                BSTwoWeaponFight.IsVisible = false;
                BSGreateWeapon.IsVisible = false;
                BSDuel.IsVisible = false;
                BSShooting.IsVisible = false;
            }
            if (BSPickW.SelectedIndex == 2)
            {
                BSDeffense.IsVisible = false;
                BSProtection.IsVisible = false;
                BSTwoWeaponFight.IsVisible = false;
                BSGreateWeapon.IsVisible = true;
                BSDuel.IsVisible = false;
                BSShooting.IsVisible = false;
            }
            if (BSPickW.SelectedIndex == 3)
            {
                BSDeffense.IsVisible = false;
                BSProtection.IsVisible = false;
                BSTwoWeaponFight.IsVisible = true;
                BSGreateWeapon.IsVisible = false;
                BSDuel.IsVisible = false;
                BSShooting.IsVisible = false;
            }
            if (BSPickW.SelectedIndex == 4)
            {
                BSDeffense.IsVisible = false;
                BSProtection.IsVisible = false;
                BSTwoWeaponFight.IsVisible = false;
                BSGreateWeapon.IsVisible = false;
                BSDuel.IsVisible = false;
                BSShooting.IsVisible = true;
            }
            if (BSPickW.SelectedIndex == 5)
            {
                BSDeffense.IsVisible = false;
                BSProtection.IsVisible = false;
                BSTwoWeaponFight.IsVisible = false;
                BSGreateWeapon.IsVisible = false;
                BSDuel.IsVisible = true;
                BSShooting.IsVisible = false;
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

        private void WWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void BattleWeapon2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (BattleWeapon2.IsChecked == true)
            {
                WeaponWar2.IsVisible= true;
                ShildAndWeaponSL.IsVisible = false;
            }
            else
            {
                WeaponWar2.IsVisible = false;
                ShildAndWeaponSL.IsVisible = true;
            }
        }

        private void shieldAndBattleWeapon_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void WWeapon2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}