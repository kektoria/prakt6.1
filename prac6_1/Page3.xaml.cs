using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac6_1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		string _text;

		public Page3 (string text)
		{
			InitializeComponent();
			_text = text;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			Vivod_stihi.Text = $"{_text}";
        }
    }
}