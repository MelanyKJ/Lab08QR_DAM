using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DAM_Lab07.Droid.ImplementsInterface;
using DAM_Lab07.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


[assembly: Dependency(typeof(QRScannerService))]namespace DAM_Lab07.Droid.ImplementsInterface
{
    public class QRScannerService : IQRScannerService
    {
        public async Task<string> QRScannerRead()
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Lectura de QR";
                var qr_result = await scanner.Scan();
                return qr_result.Text;
                /*if (result != null) 
                {
                    txtResultado.Text = result.Text;
                }*/

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return e.Message;
                //await DisplayAlert("Error", e.Message.ToString(), "OK");
            }
        }
    }
}
