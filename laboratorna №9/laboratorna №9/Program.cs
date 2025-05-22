using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Time time =new Time();
            Console.WriteLine("Об'єкт створений конструктором за замовчуванням: ");
            Console.WriteLine(Time.title()+time.ToString());

            inputData(ref time);

            Console.WriteLine("Об'єкт створений конструктором з параметрами: ");
            Console.WriteLine(Time.title() + time.ToString());

            changeTimeSeconds(ref time);
            Console.WriteLine("Об'єкт зі зміненими секундами: ");
            Console.WriteLine(Time.title() + time.ToString());

            changeTimeMinutes(ref time);
            Console.WriteLine("Об'єкт зі зміненими хвилинами: ");
            Console.WriteLine(Time.title() + time.ToString());

            changeTimeHours(ref time);
            Console.WriteLine("Об'єкт зі зміненими годинами: ");
            Console.WriteLine(Time.title() + time.ToString());

            Console.ReadKey();

        }

        static void inputData(ref Time time)
        {
            bool switchInput = true;
            while (switchInput) 
            {
                try
                {
                    Console.Write("Введіть години: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Введіть хвилини: ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.Write("Введіть секунди: ");
                    int seconds = int.Parse(Console.ReadLine());
                    time = new Time(hours, minutes, seconds);
                    switchInput = false;
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        static void changeTimeSeconds(ref Time time)
        {
            bool switchTime = true;
            while (switchTime)
            {
                Console.Write("Введіть секунди на скільки змінити значення часу: ");
                try
                {
                    time.changeTimeSeconds(int.Parse(Console.ReadLine()));
                    switchTime = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        static void changeTimeMinutes(ref Time time)
        {
            bool switchTime = true;
            while (switchTime)
            {
                Console.Write("Введіть хвилини на скільки змінити значення часу: ");
                try
                {
                    time.changeTimeMinuses(int.Parse(Console.ReadLine()));
                    switchTime = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        static void changeTimeHours(ref Time time)
        {
            bool switchTime = true;
            while (switchTime)
            {
                Console.Write("Введіть години на скільки змінити значення часу: ");
                try
                {
                    time.changeTimeHours(int.Parse(Console.ReadLine()));
                    switchTime = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
