using System;
using System.Text;

namespace Polyclinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int numberOfPatients;
            int timeOfReceptionInMinutes = 10;
            int hoursInQueue;
            int minutesInQueue;
            int hourInMinutes = 60;

            Console.Write(" Введите количество пациентов в очереди: ");
            numberOfPatients = Convert.ToInt32(Console.ReadLine());

            hoursInQueue = timeOfReceptionInMinutes * numberOfPatients / hourInMinutes;
            minutesInQueue = timeOfReceptionInMinutes * numberOfPatients % hourInMinutes;

            Console.WriteLine($" Вы должны отстоять в очереди {hoursInQueue} час(а) и {minutesInQueue} минут. ");
        }
    }
}