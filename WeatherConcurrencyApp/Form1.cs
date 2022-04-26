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
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
        }



        ///ç
        ///

        private void Form1_Load(object sender, EventArgs e)
        {
            // Leemos el archivo 'postres.json' 
            using (StreamReader archivo = File.OpenText(@"C:\Users\STEFFANIA SALGADO\Downloads\JsonCiudadesNicaragua.json"))

            {
                // Leemos los datos del archivo 'postre.json' desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el archivo 'postres.json' 
                dynamic miarray = JsonConvert.DeserializeObject(json);

                // Recorremos el array de datos del JSON 
                foreach (var item in miarray)
                {
                    // Agregamos el campo nombre del archivo 'postres.json' al ComboBox 
                    comboBox1.Items.Add(item.City);

                }
                //C:\Users\STEFFANIA SALGADO\Downloads\JsonCiudadesNicaragua.txt
            }
        }




        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();
                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel();
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {

            }

        }

        public async Task Request()
        {
            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync("Managua");
        }






    }//

}//


 
