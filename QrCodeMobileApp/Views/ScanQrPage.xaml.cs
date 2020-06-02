using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace QrCodeMobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ScanQrPage : ContentPage
    {
        public ScanQrPage()
        {
            InitializeComponent();
        }

        private async void ScanButtonClicked(object sender, EventArgs e)
        {
            var scannerPage = new ZXingScannerPage{Title = "Scanning QR Code..."};

            scannerPage.OnScanResult += result => {
                // Stop scanning
                scannerPage.IsScanning = false;

                // Alert with the scanned code
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert(" Scanned code ", result.Text, " OK ");
                });
            };


            await Navigation.PushAsync(scannerPage);
        }

        private async void GenerateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarcodePage());
        }
    }
}