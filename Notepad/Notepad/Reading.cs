using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Reading
    {        
        public void ReadFile(string path, bool accept)
        {            
            if (File.Exists(path))
            {
                using (FileStream content = new FileStream(path, FileMode.Open))
                {
                    byte[] array = new byte[content.Length];
                    content.Read(array, 0, array.Length);
                    Console.WriteLine(Encoding.Default.GetString(array));

                    if(accept == false)
                    {
                        Console.ReadLine();
                    }                 
                }
            }
        }
    }
}
