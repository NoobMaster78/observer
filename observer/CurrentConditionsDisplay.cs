using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void dispaly()
        {
            Console.WriteLine("Текущее состояние: " + temperature
                 + " C и " + humidity + "% влажности и "
                 + pressure + "мм давления"); ;
        }
        public void update(float temperature, float humidity, float preassure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            dispaly();
        }
    }
}
