using Examen2Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen2Parcial.Models.weather;

namespace Examen2Parcial.Services
{
    interface IProxy
    {
        WeatherObject Weather(string ciudad);
        ForecastRoot Forecast(string ciudad);
    }
}
