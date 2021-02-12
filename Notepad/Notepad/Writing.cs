using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Writing
    {
        string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
        protected void OutText()
        {
            Console.Clear();
            Console.WriteLine("Введите текст для файла (Чтобы вернуться в меню нажмите Enter):");
            Console.WriteLine();
        }
        public void WriteFile()
        {
            OutText();
            StreamWriter output = new StreamWriter(path);
            if(!File.Exists(path))
            {
                File.Create(path);
            }

            output.Write(Console.ReadLine());

            output.Close();
            Console.Clear();
        }
        public void WriteEdit()
        {
            if(File.Exists(path))
            {
                StreamWriter output = File.AppendText(path);

                output.Write(Console.Read());
                output.Close();
            }
        }
    }
}
