using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument(string path)
        {
            Console.WriteLine("The document is open");
            if (File.Exists(path))
            {
                var fileStr = File.ReadAllLines(path);
                StringBuilder sb = new StringBuilder();
                foreach (var c in fileStr)
                {
                    sb.Append(c);
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("File is not exist");
            }
        }
        public virtual void EditDocument(string path)
        {
            Console.WriteLine("Document editing is available in the pro version");
        }
        public virtual void SaveDocument(string path)
        {
            Console.WriteLine("Saving the document is available in the pro version");
        }
    }
}
