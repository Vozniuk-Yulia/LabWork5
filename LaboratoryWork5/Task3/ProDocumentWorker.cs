using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument(string path)
        {
            if (File.Exists(path))
            {
                var fileStr = File.ReadAllLines(path);
                StringBuilder sb = new StringBuilder();
                foreach (var c in fileStr)
                {
                    sb.Append(c);
                }
                Console.WriteLine(sb.ToString());
                string content = Console.ReadLine();
                File.WriteAllText(path, content);
            }
            Console.WriteLine("The document has been edited");
        }
        public override void SaveDocument(string path)
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
        }
    }
}
