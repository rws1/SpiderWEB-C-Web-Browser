using System.Windows.Forms;

namespace MVC_IP_CW.View
{
    public partial class renderPage : Form
    {
        private string url;

        public renderPage(string url)
        {
            this.url = url;
            this.CenterToScreen();
            InitializeComponent();
            webBrowser.Navigate(url);
        }
    }
}
