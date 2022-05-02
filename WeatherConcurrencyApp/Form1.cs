using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrencyApp.Infrastructure.Repository;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public static string path = "D:\\WeatherConcurrencyApp2M1\\WeatherConcurrencyApp.Infrastructure\\Json\\Ciudades.Json";
        public List<string> departamentos;
        public JsonCities jsonCities = new JsonCities();
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        public string SelecciondCiudad;
        public FrmMain()
        {
            var ciudades = jsonCities.GetCitiesJsonFromFile(path);
            this.departamentos = jsonCities.DeserializeJsonFile(ciudades);
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
        }


        public void agregarItems()
        {
            for (int i = 0; i < departamentos.Count; i++)
            {
                comboBox1.Items.Add(departamentos[i]);
            }
        }




        private void btnOk_Click(object sender, EventArgs e)
        {
            SelecciondCiudad = comboBox1.SelectedItem.ToString();
            try
            {
                Task.Run(Request).Wait();
                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel();
                ClimaDeLaCiudad(weatherPanel);
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {

            }

        }

        public void ClimaDeLaCiudad(WeatherPanel weatherPanel)
        {
            weatherPanel.longitud.lblDetailValue.Text = openWeather.Coord.Lon.ToString();
            weatherPanel.latitud.lblDetailValue.Text = openWeather.Coord.Lat.ToString();
            weatherPanel.temperatura.lblDetailValue.Text= openWeather.Main.Temp.ToString();
            weatherPanel.dw4.lblDetailValue.Text = openWeather.Main.Feels_like.ToString();
            weatherPanel.dw5.lblDetailValue.Text = openWeather.Main.Temp_min.ToString();
            weatherPanel.dw6.lblDetailValue.Text = openWeather.Main.Temp_max.ToString();
            weatherPanel.dw7.lblDetailValue.Text = openWeather.Main.Pressure.ToString();
            weatherPanel.dw8.lblDetailValue.Text = openWeather.Main.Humidity.ToString();
            weatherPanel.dw9.lblDetailValue.Text = openWeather.Visibility.ToString();
            weatherPanel.dw10.lblDetailValue.Text = openWeather.Wind.Speed.ToString();
            weatherPanel.dw11.lblDetailValue.Text = openWeather.Sys.Sunrise.ToString();
            weatherPanel.dw12.lblDetailValue.Text = openWeather.Sys.Sunset.ToString();
            weatherPanel.dw13.lblDetailValue.Text = openWeather.Timezone.ToString();

        }

        
        public async Task Request()
        {
            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(SelecciondCiudad.ToString());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            agregarItems();

        }
    }//

}//


 
