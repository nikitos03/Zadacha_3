using System;

namespace ЕНГ_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            string vvodpassword;
            int popitka = 3;
            while(popitka > 0)
            {
                Console.WriteLine("Введите пароль: ");
                vvodpassword = Console.ReadLine();
                if (password == vvodpassword)
                {
                    Console.WriteLine("Секретное сообщение: Задача 3");
                }
                else
                {
                    popitka--;
                    Console.WriteLine("Вы ввели неправильный пароль, у Вас осталось: " + popitka + " попытки что-бы ввести правильный пароль");
                }
            }
            return;
        }
    }
}
