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
        public WeatherPanel()
        {
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            DetailsWeather dw1 = new DetailsWeather();
            dw1.lblDetail.Text = "longitud";
            flpContent.Controls.Add(dw1);

            DetailsWeather dw2 = new DetailsWeather();
            dw2.lblDetail.Text = "latitud";
            flpContent.Controls.Add(dw2);

            DetailsWeather dw3 = new DetailsWeather();
            dw3.lblDetail.Text = "temperatura";
            flpContent.Controls.Add(dw3);

            DetailsWeather dw4 = new DetailsWeather();
            dw4.lblDetail.Text = "feels_like";
            flpContent.Controls.Add(dw4);

            DetailsWeather dw5 = new DetailsWeather();
            dw5.lblDetail.Text = "temp_min";
            flpContent.Controls.Add(dw5);

            DetailsWeather dw6 = new DetailsWeather();
            dw6.lblDetail.Text = "temp_max";
            flpContent.Controls.Add(dw6);

            DetailsWeather dw7 = new DetailsWeather();
            dw7.lblDetail.Text = "pressure";
            flpContent.Controls.Add(dw7);

            DetailsWeather dw8 = new DetailsWeather();
            dw8.lblDetail.Text = "humidity";
            flpContent.Controls.Add(dw8);

            DetailsWeather dw9 = new DetailsWeather();
            dw9.lblDetail.Text = "visibility";
            flpContent.Controls.Add(dw9);

            DetailsWeather dw10 = new DetailsWeather();
            dw10.lblDetail.Text = "speed";
            flpContent.Controls.Add(dw10);

            DetailsWeather dw11 = new DetailsWeather();
            dw11.lblDetail.Text = "sunrise";
            flpContent.Controls.Add(dw11);

            DetailsWeather dw12 = new DetailsWeather();
            dw12.lblDetail.Text = "sunset";
            flpContent.Controls.Add(dw12);

            DetailsWeather dw13 = new DetailsWeather();
            dw13.lblDetail.Text = "timezone";
            flpContent.Controls.Add(dw13);
        }
    }
}
