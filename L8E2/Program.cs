using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Задание №2. Константы и поля для чтения
class ConstAndReadOnly
{
   public const double E = 2.71828;
   public readonly int id;
   public ConstAndReadOnly(int id)
   {
      this.id = id;
   }
}
Создайте объект класса ConstAndReadOnly. 
Выведите на экран значения полей E и id. Попробуйте изменить значения данных полей.*/


namespace Lesson8Exercise2
{
    class ConstAndReadOnly
    {
        public const double E = 2.71828;
        public readonly int id;
        public ConstAndReadOnly(int id)
        {
            this.id = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstAndReadOnly c1 = new ConstAndReadOnly(35);
            Console.WriteLine("E = " + ConstAndReadOnly.E);
            Console.WriteLine("id = " + c1.id);
            
        }
    }
}
