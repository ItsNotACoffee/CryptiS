using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptiS
{
    class WorkingDir
    {
        public static string directory { get; set; }

        public static void save (string content, string fileName)
        {
            File.WriteAllText(directory + "\\" + fileName, content);
        }
    }
}
