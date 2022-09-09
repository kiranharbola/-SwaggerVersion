using System;

namespace testversioning
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class WeatherForecastversion
    {
        public DateTime Datefromversion { get; set; }

        public int TemperatureCfromversion { get; set; }

        public int TemperatureFfromversion => 32 + (int)(TemperatureCfromversion / 0.5556);

        public string Summaryfromversion { get; set; }
    }
}
