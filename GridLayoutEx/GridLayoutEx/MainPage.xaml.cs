using GridLayoutEx.All_Concepts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridLayoutEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Display.Clicked += Display_Clicked;
            Barcode.Clicked += Barcode_Clicked;

        }

        private void Barcode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Concepts());
        }

        private void Display_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Concepts());
        }
    }
}
