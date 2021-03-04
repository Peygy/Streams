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
                using (StreamReader content = new StreamReader(path))
                {                   
                    Console.Write(content.ReadToEnd());
                    if(accept == false)
                    {
                        Console.ReadLine();
                    }                 
                }
            }
        }
    }
}
