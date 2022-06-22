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
    public partial class MainPage1 : ContentPage
    {
        public MainPage1()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Page1, Message>("Subs1","Page1Message",MessageFunction);

        }

        public void MessageFunction(Page1 sender, Message arg)
        {
            labelSender.Text = sender.Title;
            labelTopic.Text = arg.Topic;
            labelContent.Text = arg.Content;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}