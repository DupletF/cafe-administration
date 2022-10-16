using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace администрирование_кафе
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 5), new Table(2, 10), new Table(3, 20) };

            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе\n");
                
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }


                Console.WriteLine("\nВведите номер стола - ");                
                int UserTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("\nВведите количество мест - ");
                int UserPlace = Convert.ToInt32(Console.ReadLine());

                bool isReserve = tables[UserTable].Reserve(UserPlace);

                if (isReserve)
                {
                    Console.WriteLine("Бронь прошла успешно!");
                }
                else
                {
                    Console.WriteLine("Ошибка брони!");
                }
                Console.ReadKey();
                Console.Clear();
            }


        }
    }

    class Table
    {
        private int _number;
        private int _maxPlace;
        private int _freePlace;

        public Table(int number, int maxPlace)
        {
            _number = number;
            _maxPlace = maxPlace;
            _freePlace = maxPlace;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Стол - " + _number + ". Свободно мест - " + _freePlace + "/" + _maxPlace);
        }

        public bool Reserve(int place)
        {
            bool isReserve;

            isReserve = _freePlace >= place;

            if (isReserve)
            {
                _freePlace -= place;
                return isReserve;
            }
            else
            {
                return isReserve;
            }
        }
    }

}
