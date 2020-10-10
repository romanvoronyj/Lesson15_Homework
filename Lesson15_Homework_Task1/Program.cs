using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Homework_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Notebook myNotebook = new Notebook("MacBook Pro 2019", "Apple", 30000);
            myNotebook.DisplayInfo();

            Console.ReadKey();
        }
    }
}
