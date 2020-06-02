using System.Threading.Tasks;
using QrCodeMobileApp.Droid;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(QrScanningService))]

namespace QrCodeMobileApp.Droid
{
    public class QrScanningService : IScanService
    {
        public async Task<string> Scan()
        {
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}