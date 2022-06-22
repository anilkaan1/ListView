using ListView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView.ViewModels
{
    public class EditPageViewModel:INotifyPropertyChanged
    {
        Car selectedCar;
        string brand;
        string model;
        string year;
        string details;
        string imageUrl;
        ImageSource imgSource;
        ICommand saveCommand;
        public EditPageViewModel(Car car)
        {
            SelectedCar = car;
            Brand = car.Brand;
            Model = car.Model;
            Year = car.Year;
            Details = car.Details;
            ImgSource= car.ImgSource;

            SaveCommand = new Command(saveFunction);


        }

        async void saveFunction()
        {
            SelectedCar.Brand = Brand;
            SelectedCar.Model = Model;
            SelectedCar.Year = year;
            SelectedCar.Details = details;
            SelectedCar.ImgSource = imgSource;

            await App.Current.MainPage.Navigation.PopAsync();

            MessagingCenter.Send<string, string>("MainPage", "EditMessage", "ok");

        }

        public EditPageViewModel()
        {

        }

        public Car SelectedCar { get => selectedCar; set => selectedCar = value; }
        public string Brand
        {
            get => brand; set
            {
                if (brand != value)
                    brand = value;
            }
        }
        public string Model { get => model; set
            {
                if (model != value)
                    model = value;
            }
        }
        public string Year { get => year; set
            {
                if (year != value)
                    year = value;
            }
        }
        public string Details { get => details; set
            {
                if (details != value)
                    details = value;
            }
        }
        public string ImageUrl { get => imageUrl; set
            {
                if (imageUrl != value)
                {
                    imageUrl = value;
                    ImgSource = ImageSource.FromUri(new Uri(ImageUrl));
                }
                    

            }
        }
        public ImageSource ImgSource { get => imgSource; set
            {
                if (imgSource != value)
                {
                    imgSource = value;
                    OnPropertyChanged("ImgSource");
                }
            }
        }

        public ICommand SaveCommand { get => saveCommand; set => saveCommand = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
