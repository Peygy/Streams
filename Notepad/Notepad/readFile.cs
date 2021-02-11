using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class readFile
    {
        public void ReadFile()
        {
            string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
            if (File.Exists(path))
            {
                Console.Clear();
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine();

                StreamReader content = new StreamReader(path);

                Console.WriteLine(content.ReadToEnd());
                Console.WriteLine("Чтобы вернуться в меню нажмите Enter");
                Console.ReadLine();
                content.Close();
                Console.Clear();
            }          
        }
    }
}
