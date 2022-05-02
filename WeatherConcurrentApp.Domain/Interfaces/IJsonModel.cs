using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Interfaces
{
    public interface IJsonModel
    {
        string GetCitiesJsonFromFile(string path);

        List<string> DeserializeJsonFile(string citiesJsonFromFile);
    }
}
