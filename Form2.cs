using System.Windows.Forms;

namespace VKProfiler
{
    public partial class Form2 : Form
    {

        public string Token { get; private set; }

        public Form2(string uri)
        {
            InitializeComponent();            
            webBrowser1.Navigate(uri);
            Token = "";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var url = e.Url;
            if (url.Scheme + "://" + url.Host + url.LocalPath == "https://oauth.vk.com/blank.html")
            {
                Token = url.OriginalString;
                webBrowser1.Document.Body.InnerText = "Теперь можно закрыть это окно";
            }            
        }
    }
}
