using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;
            string temp = "";
            string date; // 24/11/98

            Console.Write("Введите дату рождения(dd/mm/yyyy): ");
            date = Console.ReadLine();

            try { 
                if (date[2].CompareTo('/') == 0 && date[5].CompareTo('/') == 0)
                {                     
                    temp += ExtractNum(date, 0, 2);

                    dd = int.Parse(temp);
                    temp = "";                   

                    temp += ExtractNum(date, 3, 5);
                    mm = int.Parse(temp);
                    temp = "";                   

                    temp += ExtractNum(date, 5, date.Length);
                    yy = int.Parse(temp);
                    temp = "";
                }
                else
                {
                    Console.WriteLine("Неправильный формат даты(dd/mm/yyyy)!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Недопустимый формат, присутствуют символы!");
            }
            
            Console.WriteLine(CheckDateRange(dd, mm, yy) ? "Неверно указан диапазон значений!" : " ");

            CheckZodiak(dd, mm, yy);
            Console.ReadKey();
        }

        public static bool CheckDateRange(int d, int m, int y)
        {
            if ((d > 31 || d < 1) || (m > 12 || m < 1) || (y > 2017 || y < 1900))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ExtractNum(string d, int start, int finish)
        {
            string t = "";
            for (int i = start; i < finish; i++)
            {
                if (char.IsNumber(d[i]))
                {
                    t += d[i];
                }
            }

            return t;
        }
        public static void CheckZodiak(int d, int m, int y)
        {
            if((m == 3 && d >= 21) || (m == 4 && d <= 20))
            {
                Console.WriteLine("Ваш знак зодиака: Овен!");
            }
            else if ((m == 4 && d >= 21) || (m == 5 && d <= 21))
            {
                Console.WriteLine("Ваш знак зодиака: Телец!");
            }
            else if ((m == 5 && d >= 22) || (m == 6 && d <= 21))
            {
                Console.WriteLine("Ваш знак зодиака: Близнецы!");
            }
            else if ((m == 6 && d >= 22) || (m == 7 && d <= 23))
            {
                Console.WriteLine("Ваш знак зодиака: Рак!");
            }
            else if ((m == 7 && d >= 24) || (m == 8 && d <= 23))
            {
                Console.WriteLine("Ваш знак зодиака: Лев!");
            }
            else if ((m == 8 && d >= 24) || (m == 9 && d <= 23))
            {
                Console.WriteLine("Ваш знак зодиака: Дева!");
            }
            else if ((m == 9 && d >= 24) || (m == 10 && d <= 23))
            {
                Console.WriteLine("Ваш знак зодиака: Весы!");
            }
            else if ((m == 10 && d >= 24) || (m == 11 && d <= 22))
            {
                Console.WriteLine("Ваш знак зодиака: Скорпион!");
            }
            else if ((m == 11 && d >= 23) || (m == 12 && d <= 21))
            {
                Console.WriteLine("Ваш знак зодиака: Стрелец!");
            }
            else if ((m == 12 && d >= 22) || (m == 1 && d <= 20))
            {
                Console.WriteLine("Ваш знак зодиака: Козерог!");
            }
            else if ((m == 1 && d >= 21) || (m == 2 && d <= 19))
            {
                Console.WriteLine("Ваш знак зодиака: Водолей!");
            }
            else if ((m == 2 && d >= 20) || (m == 3 && d <= 20))
            {
                Console.WriteLine("Ваш знак зодиака: Рыбы!");
            }
            else
            {
                Console.WriteLine("Неправильно введена дата!");
            }
        }
    }
}
