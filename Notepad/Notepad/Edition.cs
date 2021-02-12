using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Edition
    {
        Writing write = new Writing();
        Viewing view = new Viewing();

        string path = @"D:\Программирование\С#\Repos\Streams\Notepad\test.txt";
        protected void OutText()
        {
            Console.Clear();
            Console.WriteLine("Дозапись файла (Чтобы вернуться в меню нажмите Enter):");
            Console.WriteLine();
        }
        public void EditFile()
        {                    
            if (File.Exists(path))
            {
                OutText();
                view.ViewEdit();
                write.WriteEdit();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
