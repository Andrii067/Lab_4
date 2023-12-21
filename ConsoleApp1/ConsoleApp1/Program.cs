using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ініціалізація колекції для зберігання метеорологічних даних
        List<MeteorologicalData> weatherData = new List<MeteorologicalData>();

        // Додавання даних
        weatherData.Add(new MeteorologicalData(DateTime.Now, 25.0, 60.0, 1013.0));
        weatherData.Add(new MeteorologicalData(DateTime.Now.AddHours(-1), 24.5, 65.0, 1012.5));

        // Оновлення даних (наприклад, оновити дані за певний час)
        DateTime timeToUpdate = DateTime.Now.AddHours(-1);
        foreach (var data in weatherData)
        {
            if (data.Time == timeToUpdate)
            {
                data.Temperature = 26.0; // нова температура
            }
        }

        // Видалення даних (наприклад, видалити старі дані)
        weatherData.RemoveAll(data => data.Time < DateTime.Now.AddHours(-2));

        // Вивід даних для перевірки
        foreach (var data in weatherData)
        {
            Console.WriteLine($"Час: {data.Time}, Температура: {data.Temperature}, Вологiсть: {data.Humidity}, Тиск: {data.Pressure}");
        }
    }
}

public class MeteorologicalData
{
    public DateTime Time { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public MeteorologicalData(DateTime time, double temperature, double humidity, double pressure)
    {
        Time = time;
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }
}
