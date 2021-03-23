using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Writing
    {        
        public void WriteFile(string path, bool append)
        {
            string key = "";
            using (FileStream output = new FileStream(path, FileMode.OpenOrCreate)) //Создание файла с FileStream
            {                
                while (!key.Contains("stop") && !key.Contains("стоп"))
                {
                    byte[] array = Encoding.Default.GetBytes(key);
                    output.Write(array, 0, array.Length);

                    key = Console.ReadLine();
                }
            }
        }
    }
}
