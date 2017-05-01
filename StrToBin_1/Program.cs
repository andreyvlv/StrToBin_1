using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StrToBin_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите слово:");
            // Запрашиваем ввод слова и присваиваем его строке str
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Бинарное прдеставление =>");
            // Используем метод StrToBinary
            StrToBinary(str);            
            Console.ReadKey();
        }

        static void StrToBinary(string str)
        {
            /*
            // Конверитировать слово str в массив символов charArr
            char[] charArr = str.ToCharArray();
            // Коллекция для хранения строкового бинарного представления буквы (нужна для функции Reverse)
            List<string> outputList = new List<string>();
            // Массив для хранения байтового представления буквы
            byte[] bf = new byte[1];
            // Цикл вывода двоичного представления
            for (int i = 0; i < charArr.Length; i++)
            {
                // Т.к. колл. BitArray принимает массив байтов, 
                // то для представления единичного символа используем единственный элемент массива bf
                bf[0] = (byte)charArr[i];
                // Создаем бинарную колл. BitArray для конвертации в бинарное представление единичного символа
                BitArray ba = new BitArray(bf);
                // Добавляем строковое представление  каждого элемента ba в outputList
                foreach (var b in ba)
                {
                    outputList.Add(b.ToString());
                }
                // Разворачиваем колл. обратно
                outputList.Reverse();
                // Вывод двоичного представления буквы 
                foreach (string s in outputList)
                {
                    // В зависимости от значения элемента колл. outputList выводим либо 1, либо 0
                    if (Convert.ToBoolean(s))
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                // Очищаем коллекцию outputList
                outputList.Clear();
                Console.WriteLine();
            }   
            */
            var a = str.Select(i => "0" + Convert.ToString(i, 2));
            foreach (var s in a)
                Console.WriteLine(s);
        }
    }
}
