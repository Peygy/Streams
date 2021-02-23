using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Edition
    {
        Writing write = new Writing();
        Reading read = new Reading();
        private void OutText()
        {
            Console.Clear();
            Console.WriteLine("Дозапись файла (Чтобы вернуться в меню нажмите Enter):");
            Console.WriteLine();
        }
        public void EditFile(string path, bool accept)
        {                    
            if (File.Exists(path))
            {
                OutText();
                read.ReadFile(path, accept);
                write.WriteFile(path, accept);
                Console.ReadLine();           
            }
        }
    }
}
