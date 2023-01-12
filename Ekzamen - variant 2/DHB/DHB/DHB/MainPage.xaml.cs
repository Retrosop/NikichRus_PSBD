using System;
using Xamarin.Forms;
using DHB.Data;
using System.IO;

namespace DHB
{
    public partial class MainPage : ContentPage
    {

        static HeroesDB heroesDB;

        public static HeroesDB HeroesDB
        {
            get
            {
                if(heroesDB == null)
                {
                    heroesDB = new HeroesDB
                        (
                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),

                        "DHBDataBase.db3"));
                }
                return heroesDB;
            }
        }

        public MainPage()
        {
            InitializeComponent();

        }

        private async void OpenCreator(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        private  void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override async void OnAppearing() //появление заметок
        {
            CollectionView.ItemsSource = await MainPage.HeroesDB.GetHeroesAsync();

            base.OnAppearing();
        }

    }



}
