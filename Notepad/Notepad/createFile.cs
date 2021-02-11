using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class createFile
    {
        public void CreateFile()
        {
            string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            Console.Clear();
            Console.WriteLine("Введите текст для файла:");
            Console.WriteLine();

            StreamWriter output = new StreamWriter(path);

            output.WriteLine(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Чтобы вернуться в меню нажмите Enter");
            Console.ReadLine();
            output.Close();
            Console.Clear();
        }
    }
}
