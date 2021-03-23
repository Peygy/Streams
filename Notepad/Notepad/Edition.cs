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
        public void EditFile(string path) //Дозапись файла
        {
            if (File.Exists(path))
            {
                read.ReadFile(path, true);
                write.WriteFile(path, true);       
            }
        }
    }
}
