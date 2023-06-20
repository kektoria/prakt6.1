using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prac6_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonSign_Clicked(object sender, EventArgs e)
        {
            if (EntryLogin.Text != null && EntryLogin.Text != "" && EntryPassword.Text != null && EntryPassword.Text != "")
            {             
                await Navigation.PushAsync(new Page2(EntryLogin.Text));                       
            }
            else
            {
                await DisplayAlert("Внимание", "Заполинте строки!", "OK");
            }
        }
    }
}
