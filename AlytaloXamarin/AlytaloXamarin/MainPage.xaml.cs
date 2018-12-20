using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlytaloXamarin
{

    public partial class MainPage : ContentPage
    {


        public class SaunaClass
        {
        private int saunanLampotila { get; set; }
        private string saunaPaalla { get; set; }
        }

        private string uri = "https://alytalocontroller.azurewebsites.net/sauna/";
        HttpClient client = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }


        private async void Sauna_clicked(object sender, EventArgs e)
            {
            SaunanNykyLampotila.Text = uri;

            var content = "";
            HttpClient webClient = new HttpClient();
            var url = "https://alytalocontroller.azurewebsites.net/sauna/";
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(url);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<SaunaClass>>(content);
            SaunanTila.ItemsSource = Items;

        }
        private void Valot_clicked(object sender, EventArgs e)
        {
            ValonTila.Text = "Pällä/pois";
            ValonMaara.Text = "tähän tulee kirkkaus 0-10";
        }
        private void Termostaatti_clicked(object sender, EventArgs e)
        {
            TalonTavoiteLampotila.Text = "Celsius";
            TalonNykyLampotila.Text = "Celsius";
        }
    }
}
