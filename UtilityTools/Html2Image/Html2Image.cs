using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Html2Image
{
    public class Html2Image
    {
        private string ImagePath { get; set; }
        public void Main(string htmlSourceCode, string imagePath)
        {
            ImagePath = imagePath;
            StartBrowser(htmlSourceCode);
        }

        private void StartBrowser(string source)
        {
            var th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.ScrollBarsEnabled = false;
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
                webBrowser.DocumentText = source;
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var webBrowser = (WebBrowser)sender;
            using (Bitmap bitmap = new Bitmap( webBrowser.Width, webBrowser.Height))
            {
                webBrowser.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, 9999, 99999));
                bitmap.Save(ImagePath+"/Image.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}
