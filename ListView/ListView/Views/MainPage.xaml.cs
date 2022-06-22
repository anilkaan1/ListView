using ListView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Car car = ((Xamarin.Forms.ListView)sender).SelectedItem as Car; //CAST ing
            if (car == null)
                return;
            else
                await Navigation.PushAsync(new NavigationPage(new DetailedPage(car)));


        }

        //async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Car car = ((Xamarin.Forms.CollectionView)sender).SelectedItem as Car;
        //    if (car == null)
        //        return;
        //    else
        //        await Navigation.PushAsync(new NavigationPage(new DetailedPage(car)));
        //}

        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new TablePage());
        //}
    }
}