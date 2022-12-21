using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DiscordWebhookSender
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            
            Embed embed = new Embed();

            
            embed.title = TitleTextBox.Text;
            embed.description = DescriptionTextBox.Text;
           // embed.url = UrlTextBox.Text; (SOON)
           // embed.color = (int)ColorPicker.SelectedColor.Value.ToArgb(); (SOON)
            embed.timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ");

            
            Webhook webhook = new Webhook();
            webhook.url = WebhookUrlTextBox.Text;

            
            webhook.embeds = new List<Embed>() { embed };

            
            string json = JsonConvert.SerializeObject(webhook);

            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webhook.url);
            request.Method = "POST";
            request.ContentType = "application/json";

           
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

          
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result = "";
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

       
            MessageBox.Show(result);
        }
    }

    // Embed-Objekt
    public class Embed
    {
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public int color { get; set; }
        public string timestamp { get; set; }
    }

    // KWebhook-Objekt
    public class Webhook
    {
        public string url { get; set; }
        public List<Embed> embeds { get; set; }
    }
}



