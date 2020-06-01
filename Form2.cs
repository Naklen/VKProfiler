using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
