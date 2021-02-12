using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Viewing
    {
        string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
        protected void OutText()
        {
            Console.Clear();
            Console.WriteLine("Содержимое файла (Чтобы вернуться в меню нажмите Enter):");      
            Console.WriteLine();
        }
        public void ViewFile()
        {
            if(File.Exists(path))
            {
                StreamReader content = new StreamReader(path);

                OutText();
                Console.Write(content.ReadToEnd());
                Console.ReadLine();

                content.Close();
                Console.Clear();
            }      
        }
        public void ViewEdit()
        {
            if(File.Exists(path))
            {
                StreamReader content = new StreamReader(path);

                Console.Write(content.ReadToEnd());
                content.Close();
            }
        }
    }
}
