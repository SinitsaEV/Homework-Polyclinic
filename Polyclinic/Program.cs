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
            int hourInQueue;
            int minuteInQueue;
            int hourInMinutes = 60;

            Console.Write(" Введите количество пациентов в очереди: ");
            numberOfPatients = Convert.ToInt32(Console.ReadLine());

            hourInQueue = timeOfReceptionInMinutes * numberOfPatients / hourInMinutes;
            minuteInQueue = timeOfReceptionInMinutes * numberOfPatients % hourInMinutes;

            Console.WriteLine($" Вы должны отстоять в очереди {hourInQueue} час(а) и {minuteInQueue} минут. ");
        }
    }
}