using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Reading
    {
        private void OutText()
        {
            Console.Clear();
            Console.WriteLine("Содержимое файла (Чтобы вернуться в меню нажмите Enter):");      
            Console.WriteLine();
        }
        public void ReadFile(string path, bool accept)
        {            
            if (File.Exists(path))
            {
                using (StreamReader content = new StreamReader(path))
                {
                    if(accept == false)
                    {
                        OutText();
                    }
                    Console.Write(content.ReadToEnd());
                    Console.ReadLine();
                }            
            }

        }
    }
}
