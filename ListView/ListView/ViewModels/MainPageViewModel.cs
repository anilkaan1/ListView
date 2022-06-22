using ListView.Models;
using ListView.Services;
using ListView.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView.ViewModels
{
    public class MainPageViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<Car> Carlist;
        public ObservableCollection<Car> Carlist1
        {
            get => Carlist; set
            {
                Carlist = value;
                OnPropertyChanged("Carlist1");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        ICommand deleteCommand;
        ICommand editCommand;



        public ICommand DeleteCommand { get => deleteCommand; set => deleteCommand = value; }
        public ICommand EditCommand { get => editCommand; set => editCommand = value; }

        public void deleteFunction(Car c)
        {
            ListCreater.CarList.Remove(c);
            Carlist1 = new ObservableCollection<Car>(ListCreater.CarList);
            App.Current.MainPage.DisplayAlert("Uyarı","Silme Başarılı: "+c.Brand, "Kapat");
        }
        public async void editFunction(Car c)
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new EditPage(c)));
        }


        public MainPageViewModel()
        {
            Carlist1 = new ObservableCollection<Car>(ListCreater.getCars());

            DeleteCommand = new Command<Car>(deleteFunction);

            EditCommand = new Command<Car>(editFunction);

            MessagingCenter.Subscribe<string, string>("MainPage", "EditMessage", MessageFunction);
        }
         async void MessageFunction(string sender,string args)
        {
            if (args.Equals("ok"))
            {
                Carlist1 = new ObservableCollection<Car>(ListCreater.CarList);
                await App.Current.MainPage.DisplayAlert("Basarili","Basarili","Kapat");
            }
        }
    
    }
}
