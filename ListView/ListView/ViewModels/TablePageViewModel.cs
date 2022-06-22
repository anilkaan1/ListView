using ListView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListView.ViewModels
{
    public class TablePageViewModel
    {
        private ObservableCollection<Features> attributes;

        public TablePageViewModel()
        {
            this.attributes = new ObservableCollection<Features>() { 
                new Features { name = "Square Meters", quantity = "400" },
                new Features { name = "Room Number", quantity = "7" }, 
                new Features { name = "Floor Number", quantity = "2" }, 
                new Features { name = "Bathroom \n Number", quantity = "4" },
                new Features { name = "Garage Number", quantity = "4" } };
        }

        public ObservableCollection<Features> Attributes { get => attributes; set => attributes = value; }
    }
}
