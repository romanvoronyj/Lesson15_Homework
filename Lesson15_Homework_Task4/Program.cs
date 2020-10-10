using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_Homework_Task4
{
    /*Створіть клас MyClass і структуру MyStruct, які містять в собі поля public string change. У класі Program створіть два методи:
   - static void ClassTaker (MyClass myClass), який присвоює полю change екземпляра myClass значення «змінено».
   - static void StruktTaker (MyStruct myStruct), який присвоює полю change екземпляраmyStruct значення «змінено».
   Продемонструйте різницю у використанні класів і структур, створивши в методі Main () екземпляри структури і класу. 
   Змініть, значення полів екземплярівна «не 
    */
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
            Console.WriteLine(myClass.change);
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "змінено";
            Console.WriteLine(myStruct.change);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyClass myClass = new MyClass();
            myClass.change = "не змінено";
            Console.WriteLine(myClass.change);

            MyStruct myStruct;                    //при створенні екзампляра структури нам не потрібно викликати конструктор 
                                                  //MyStruct myStruct = new MyStruct();
            myStruct.change = "не змінено";
            Console.WriteLine(myStruct.change);

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.ReadKey();
        }
    }
}
