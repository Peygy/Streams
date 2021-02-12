using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Menu
    {
        Writing create;
        Viewing read;
        Edition write;

        public Menu()
        {
            create = new Writing();
            read = new Viewing();
            write = new Edition();
            CallMenu();
        }

        public void CallMenu()
        {
            int input = 0;
            while (input != 4)
            {
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
                    case 1:
                        {
                            Console.Clear();
                            create.WriteFile();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            read.ViewFile();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            write.EditFile();
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите номер из меню! Нажмите Enter...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
