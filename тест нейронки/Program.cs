/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество оценок:");
        int n = int.Parse(Console.ReadLine()); // количество оценок
        Console.WriteLine("Введите текущий средний балл:");
        double avg = double.Parse(Console.ReadLine()); // текущий средний балл
        int fivesNeeded = 0; // количество оценок "5", которые нужно получить

        // вычисляем, сколько оценок "5" нужно получить
        while (avg < 4.6)
        {
            fivesNeeded++;
            n++;
            avg = ((avg * (n - 1)) + 5) / n; // вычисляем новый средний балл с учетом новой оценки "5"
        }

        Console.WriteLine($"Необходимо получить {fivesNeeded} оценок '5', чтобы средний балл был выше 4.6.");
    }
}
*/

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите оценки через запятую:");
        string[] grades = Console.ReadLine().Split(','); // ввод оценок через запятую
        int n = grades.Length; // количество оценок
        double sum = grades.Sum(double.Parse); // сумма оценок
        double avg = sum / n; // текущий средний балл
        int fivesNeeded = 0; // количество оценок "5", которые нужно получить

        // вычисляем, сколько оценок "5" нужно получить
        while (avg <= 4.6)
        {
            fivesNeeded++;
            n++;
            
            sum += 5;

            avg = sum / n; // вычисляем новый средний балл с учетом новой оценки "5"
        }

        Console.WriteLine($"Необходимо получить {fivesNeeded} оценок '5', чтобы средний балл был выше 4.6.");
    }
}
