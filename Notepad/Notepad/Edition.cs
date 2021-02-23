using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notepad
{
    class Edition : Writing
    {
        Reading read = new Reading();
        public void EditFile(string path, bool accept)
        {
            if (File.Exists(path))
            {
                OutText();
                read.ReadFile(path, accept);
                WriteFile(path, accept);       
            }
        }
    }
}
