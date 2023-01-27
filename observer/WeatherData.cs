using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    class WeatherData : Subject
    {
        private List <Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public void notifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }
        public WeatherData()
        {
            observers = new List<Observer>();
        }
       
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}
