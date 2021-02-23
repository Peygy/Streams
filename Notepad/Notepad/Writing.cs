using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Writing
    {
        private void OutText()
        {
            Console.Clear();
            Console.WriteLine("Введите текст для файла (Чтобы вернуться в меню нажмите Enter):");
            Console.WriteLine();
        }
        public void WriteFile(string path, bool accept)
        {
            using (StreamWriter output = new StreamWriter(path), appending = File.AppendText(path))
            {               
                if (accept == false)
                {
                    OutText();
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    output.Write(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    appending.Write(Console.ReadLine());                   
                }
            }          
        }
    }
}
