using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlytaloXamarin
{
    public partial class MainPage : ContentPage
    {
        private int saunanLampotila;
        private string saunaPaalla;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Sauna_clicked(object sender, EventArgs e)
            {
            SaunanNykyLampotila.Text = "Tähän tulee lämpötila";
            SaunanTila.Text = "Pällä/pois";
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
