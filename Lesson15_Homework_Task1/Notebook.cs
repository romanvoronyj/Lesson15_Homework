using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Homework_Task1
{
    struct Notebook
    {
        private string modelName;
        private string brand;
        private double price;

        public Notebook(string modelName, string brand, double price)
        {
            this.modelName = modelName;
            this.brand = brand;
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Виробник: {brand}  Модель: {modelName}  Ціна: {price}");
        }
    }
}
