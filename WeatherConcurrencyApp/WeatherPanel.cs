using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {
        public DetailsWeather longitud = new DetailsWeather();
        public DetailsWeather latitud = new DetailsWeather();
        public DetailsWeather temperatura = new DetailsWeather();
        public DetailsWeather dw4 = new DetailsWeather();
        public DetailsWeather dw5 = new DetailsWeather();
        public DetailsWeather dw6 = new DetailsWeather();
        public DetailsWeather dw7 = new DetailsWeather();
        public DetailsWeather dw8 = new DetailsWeather();
        public DetailsWeather dw9 = new DetailsWeather();
        public DetailsWeather dw10 = new DetailsWeather();
        public DetailsWeather dw11 = new DetailsWeather();
        public DetailsWeather dw12 = new DetailsWeather();
        public DetailsWeather dw13 = new DetailsWeather();

        public WeatherPanel()
        {
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
           
            
            longitud.lblDetail.Text = "longitud";
            flpContent.Controls.Add(longitud);

            latitud.lblDetail.Text = "latitud";
            flpContent.Controls.Add(latitud);

            temperatura.lblDetail.Text = "Temperatura";
            flpContent.Controls.Add(temperatura);

            dw4.lblDetail.Text = "feels_like";
            flpContent.Controls.Add(dw4);

            dw5.lblDetail.Text = "temp_min";
            flpContent.Controls.Add(dw5);

            dw6.lblDetail.Text = "temp_max";
            flpContent.Controls.Add(dw6);

            dw7.lblDetail.Text = "pressure";
            flpContent.Controls.Add(dw7);

            dw8.lblDetail.Text = "humidity";
            flpContent.Controls.Add(dw8);

            dw9.lblDetail.Text = "visibility";
            flpContent.Controls.Add(dw9);

            dw10.lblDetail.Text = "speed";
            flpContent.Controls.Add(dw10);

            dw11.lblDetail.Text = "sunrise";
            flpContent.Controls.Add(dw11);

            dw12.lblDetail.Text = "sunset";
            flpContent.Controls.Add(dw12);

            dw13.lblDetail.Text = "timezone";
            flpContent.Controls.Add(dw13);
        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {

        }
    }
}
