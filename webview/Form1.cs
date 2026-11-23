using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
namespace webview2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com");
            webView22.Source = new Uri("https://www.wikipedia.org");
        }
        private void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView21.Source != null)
            {
                textBox1.Text = webView21.Source.ToString();
                string saytAdi = webView21.Source.Host.Replace("www.", "");
                if (!listBox2.Items.Contains(saytAdi))
                {
                    listBox2.Items.Insert(0, saytAdi);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com");
            textBox1.Text = "https://www.google.com";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string unvan = textBox1.Text.Trim();
            if (unvan != "")
            {
                if (!unvan.StartsWith("http://") && !unvan.StartsWith("https://"))
                {
                    unvan = "https://" + unvan;
                }
                webView21.Source = new Uri(unvan);
                textBox1.Text = unvan;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button5_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (webView21.Source != null)
            {
                string saytAdi = webView21.Source.Host.Replace("www.", "");
                if (!listBox1.Items.Contains(saytAdi))
                {
                    listBox1.Items.Add(saytAdi);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                webView21.Source = new Uri("https://" + listBox1.SelectedItem.ToString());
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                webView21.Source = new Uri("https://" + listBox2.SelectedItem.ToString());
            }
        }
    }
}