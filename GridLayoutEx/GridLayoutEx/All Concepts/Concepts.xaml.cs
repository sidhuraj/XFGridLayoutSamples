using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace GridLayoutEx.All_Concepts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Concepts : ContentPage
    {
        public Concepts()
        {
            InitializeComponent();
            //Working with Images
            //Myimages.Source = ImageSource.FromFile("hrithik.jpg");
            //Myimages.Source = new Uri("https://homepages.cae.wisc.edu/~ece533/images/airplane.png");
            Myimages.Source = ImageSource.FromResource("GridLayoutEx.FromResource.hrithik.jpg");





        }
        //Display ACtion Sheet
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("select country", "cancel", "", "india", "us", "canada", "singapore", "ok");
            if(action=="india")
            {
                DisplayActionSheet.Text = "selected country " + action;
            }
            if (action == "us")
            {
                DisplayActionSheet.Text = "selected country " + action;
            }
            if (action == "canada")
            {
                DisplayActionSheet.Text = "selected country " + action;
            }
            if (action == "singapore")
            {
                DisplayActionSheet.Text = "selected country " + action;
            }
        }
        //Barcode & QRcode Package:ZXing.Net.Mobile.Forms install and continue this Process
        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += Scan_OnScanResult;
        }

        private void Scan_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
               await Navigation.PopAsync();
                Mycode.Text = result.Text;

            });
        }
        //Toast message long and short
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var message = "this is a  long toast Message";
            DependencyService.Get<IMessage>().Longtime(message);
            //var message = "this is a  short toast Message";
            //DependencyService.Get<IMessage>().Shorttime(message);
        }
        //Display Popup 
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            var response=await DisplayAlert("Message", "Do you want TO Background color(Green)", "ok", "No");
            if (response)
            {
                this.BackgroundColor = Color.Green;
            }
            else
            {
                this.BackgroundColor = Color.White;
            }
        }

        private void switch2_Toggled(object sender, ToggledEventArgs e)
        {
            bool value = e.Value;
            sv2.Text = value.ToString();
        }
    }
}