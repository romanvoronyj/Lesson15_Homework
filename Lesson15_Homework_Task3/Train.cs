using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Homework_Task3
{
    struct Train
    {
        private string destinationCity;
        private int trainIndex;
        DateTime departingTime;

        public string DestinationCity
        {
            get
            {
                return destinationCity;
            }
            set
            {
                value = destinationCity;
            }
        }

        public int TrainIndex
        {
            get
            {
                return trainIndex;
            }
            set
            {
                value = trainIndex;
            }
        }
        public DateTime DepartingTime
        {
            get
            {
                return departingTime;
            }
            set
            {
                value = departingTime;
            }
        }

        public Train(string destinationCity, int trainIndex, DateTime departingTime)
        {
            this.destinationCity = destinationCity;
            this.trainIndex = trainIndex;
            this.departingTime = departingTime;
        }
        public void InfoTrain()
        {
            Console.WriteLine($"Місто призначення: {destinationCity}\t Поїзд №: {trainIndex}\t Час відправлення: {departingTime}");
        }
    }

}
