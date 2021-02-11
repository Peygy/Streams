using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class menu
    {
        createFile create;
        readFile read;
        writeFile write;

        public menu()
        {
            create = new createFile();
            read = new readFile();
            write = new writeFile();
            CallMenu();
        }

        public void CallMenu()
        {
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine();
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
                            create.CreateFile();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            read.ReadFile();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            write.WriteFile();
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
