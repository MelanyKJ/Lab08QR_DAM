using DAM_Lab07.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace DAM_Lab07
{
        public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BtnScannerQR_Clicked(object sender, EventArgs e)
        {
            try{
                var scanner = DependencyService.Get<IQRScannerService>();
                var qr_result = await scanner.QRScannerRead();

                if(qr_result != null){
                    txtResultado.Text = qr_result;
                }
            }catch(Exception ex){
                txtResultado.Text=ex.Message;
            }
        }
    }
}
