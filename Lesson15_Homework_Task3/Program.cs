using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Homework_Task3
{
    /*Потрібно: Описати структуру з іменем Train, що містить наступні поля: назва пункту призначення, номер поїзда, час відправлення.
      Написати програму, що виконує наступні дії:
      - введення з клавіатури даних в масив, що складається з восьми елементів типу Train (записи повинні бути впорядковані за номерами поїздів);
      - вивід на екран інформації про потяг, номер якого введено з клавіатури (якщо таких поїздів немає, вивести відповідне повідомлення).
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введіть пункт призначення:");
                string destinationCity = Console.ReadLine();

                Console.WriteLine("Введіть номер поїзда:");
                int trainIndex = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введіть час відправлення:");
                DateTime departingTime = DateTime.Parse(Console.ReadLine());

                trains[i] = new Train(destinationCity, trainIndex, departingTime);
                trains[i].InfoTrain();

                Console.WriteLine();
            }

            //int temp;
            //for (int i = 0; i < railwayStation.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < railwayStation.Length; j++)
            //    {
            //        if (railwayStation[i] > railwayStation[j])
            //        {
            //            temp = railwayStation[i];
            //            railwayStation[i] = railwayStation[j];
            //            railwayStation[j] = temp;
            //        }
            //    }
            //}

            //Вивід інфи за нмоером поїзда
            Console.WriteLine("Введіть номер поїзда:");
            int inquiryTrain = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < trains.Length - 1; i++)
            {
                if (trains[i].TrainIndex != inquiryTrain)
                {
                    Console.WriteLine("Немає.");
                }
                else
                {
                    trains[i].InfoTrain(); //виводить інформацію тільки по 1-ому поїзду. Як виправити?
                }
            }
            Console.ReadKey();
        }
    }
}
