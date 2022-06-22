﻿using ListView.Models;
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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            Message m = new Message();
            m.Topic = Topic.Text;
            m.Content = Content.Text;

            MessagingCenter.Send<Page1,Message>(this,"Page1Message",m);

            await Navigation.PopAsync();
        }
    }
}