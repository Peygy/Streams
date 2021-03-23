using System;
using System.Collections.Generic;
using System.Text;

namespace Notepad
{
    class Menu
    {
        Writing create;
        Reading read;
        Edition write;

        public Menu()
        {
            create = new Writing();
            read = new Reading();
            write = new Edition();           
        }

        public void OutText() //Метод для общения с пользователем в создании и чтении файла
        {
            Console.Clear();
            Console.WriteLine("Введите текст для файла (Чтобы вернуться в меню введите 'stop' или 'стоп'):");
            Console.WriteLine();
        }

        public void CallMenu()
        {
            string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
            int input = 0;
            while (input != 4)
            {
                Console.Clear();
                Console.WriteLine("1.Создать файл");
                Console.WriteLine("2.Прочитать файл");
                Console.WriteLine("3.Дозаписать файл");
                Console.WriteLine("4.Закрыть меню");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"Выберите пункт: ");

                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1: //Создание файла
                        {
                            Console.Clear();
                            OutText();
                            create.WriteFile(path, false);
                            break;
                        }
                    case 2: //Чтение файла
                        {
                            Console.Clear();
                            OutText();
                            read.ReadFile(path, false);
                            break;
                        }
                    case 3: //Дозапись файла
                        {
                            Console.Clear();
                            OutText();
                            write.EditFile(path);
                            break;
                        }
                    case 4: //Закрыть программу 
                        {
                            break;
                        }
                    default: //При выборе номера не из меню
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите номер из меню! Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        }
                }
            }
        }
    }
}
