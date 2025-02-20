using System;
using System.Collections.Generic;

// Classe base
public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    // Métodos abstratos que serão implementados nas classes derivadas
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Método para gerar o resumo
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min) - " +
               $"Distância {GetDistance():F1} km, Velocidade {GetSpeed():F1} km/h, Ritmo: {GetPace():F2} min por km";
    }
}

// Classe derivada de Corrida (Running)
public class Running : Activity
{
    public double DistanceInKm { get; set; }

    public Running(DateTime date, int durationInMinutes, double distanceInKm)
        : base(date, durationInMinutes)
    {
        DistanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return DistanceInKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // km/h
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // min/km
    }
}

// Classe derivada de Bicicleta Estacionária (Cycling)
public class Cycling : Activity
{
    public double SpeedInKph { get; set; }

    public Cycling(DateTime date, int durationInMinutes, double speedInKph)
        : base(date, durationInMinutes)
    {
        SpeedInKph = speedInKph;
    }

    public override double GetDistance()
    {
        return (SpeedInKph * DurationInMinutes) / 60; // km
    }

    public override double GetSpeed()
    {
        return SpeedInKph; // já fornecido em km/h
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // min/km
    }
}

// Classe derivada de Natação (Swimming)
public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0 * 0.62; // milhas
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // mph
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // min/mi
    }
}

class Program
{
    static void Main()
    {
        // Criando atividades
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 5.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        // Exibindo os resumos
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
