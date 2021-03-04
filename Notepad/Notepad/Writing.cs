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
            using (StreamWriter output = new StreamWriter(path, append))
            {                
                while (!key.Contains("stop") && !key.Contains("стоп"))
                {
                    key = Console.ReadLine();
                    if (!key.Contains("stop") && !key.Contains("стоп"))
                    {
                        output.WriteLine(key);
                    }
                }
            }
        }
    }
}
