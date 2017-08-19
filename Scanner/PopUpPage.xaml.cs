using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Scanner {
    public partial class PopUpPage : ContentPage {
        public PopUpPage() {
            InitializeComponent();
        }

        public void OnClickScan(object sender, EventArgs e) {
            ScanAsync();
        }

        public async void ScanAsync() {

            var scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) => {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);

        }
    }
}
