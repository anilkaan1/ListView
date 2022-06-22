using ListView.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.ViewModels
{
    public class DetailedPageViewModel
    {
        private Car car;

        public DetailedPageViewModel(Car car)
        {
            this.Car = car;
        }

        public Car Car { get => car; set => car = value; }
    }
}
