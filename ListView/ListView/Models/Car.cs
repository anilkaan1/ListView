using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListView.Models
{
    public class Car
    {
        int id;

        string model;

        string brand;

        string year;

        string details;

        ImageSource imgSource;

        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Year { get => year; set => year = value; }
        public string Details { get => details; set => details = value; }
        public ImageSource ImgSource { get => imgSource; set => imgSource = value; }
        public int Id { get => id; set => id = value; }
    }
}
