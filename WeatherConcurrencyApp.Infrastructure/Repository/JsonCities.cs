using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeatherConcurrentApp.Domain.Entities;
using WeatherConcurrentApp.Domain.Interfaces;

namespace WeatherConcurrencyApp.Infrastructure.Repository
{
    public class JsonCities : IJsonModel
    {
        public List<string> DeserializeJsonFile(string citiesJsonFromFile)
        {
            List<string> Cties = new List<string>();
            List<Ciudad> Ciudades = JsonConvert.DeserializeObject<List<Ciudad>>(citiesJsonFromFile);
            foreach (Ciudad item in Ciudades)
            {
                Cties.Add(item.city);
            }
            return Cties;
        }

        public string GetCitiesJsonFromFile(string path)
        {
            string CitysJsonfromfile;
            using (var reader = new StreamReader(path))
            {
                CitysJsonfromfile = reader.ReadToEnd();
            }
            return CitysJsonfromfile;
        }
    }
}
