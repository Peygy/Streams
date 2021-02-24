using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Writing
    {
        protected void OutText()
        {
            Console.Clear();
            Console.WriteLine("Введите текст для файла (Чтобы вернуться в меню введите 'stop' или 'стоп'):");
            Console.WriteLine();
        }
        public void WriteFile(string path, bool accept)
        {
            string key;
            if (accept == false)
            {
                using (StreamWriter output = new StreamWriter(path))
                {
                    key = "";
                    OutText();
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    while(!key.Contains("stop") && !key.Contains("стоп"))
                    {
                        key = Console.ReadLine();
                        if (!key.Contains("stop") && !key.Contains("стоп"))
                        {
                            output.WriteLine(key);
                        }   
                        
                    }                    
                }
            }

            else
            {
                using (StreamWriter appending = File.AppendText(path))
                {
                    key = "";
                    while (!key.Contains("stop") && !key.Contains("стоп"))
                    {
                        key = Console.ReadLine();
                        if (!key.Contains("stop") && !key.Contains("стоп"))
                        {
                            appending.WriteLine(key);
                        }                                           
                    }
                }                       
            }            
        }
    }
}
