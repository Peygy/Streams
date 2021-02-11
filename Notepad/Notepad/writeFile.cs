using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class writeFile
    {
        public void WriteFile()
        {
            string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
            if (File.Exists(path))
            {
                Console.Clear();
                Console.WriteLine("Содержимое файла(доступно для редактирования):");
                Console.WriteLine();

                StreamReader contentNew = new StreamReader(path);
                StreamWriter outputNew = new StreamWriter(path);

                Console.Write(contentNew.ReadToEnd());
                outputNew.WriteLine(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Чтобы вернуться в меню нажмите Enter");
                Console.ReadLine();
                contentNew.Close();
                Console.Clear();
            }
        }
    }
}
