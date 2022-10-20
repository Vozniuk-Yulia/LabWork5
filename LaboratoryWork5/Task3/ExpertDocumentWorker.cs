using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument(string path)
        {
            if (File.Exists(path))
            {
                var txt = string.Empty;
                using (var stream = File.OpenText(path))
                {
                    txt = stream.ReadToEnd();
                }
                var xml = new XDocument(new XElement("Data", new XElement("Info", txt)));
                xml.Save(Path.ChangeExtension(path, ".xml"));
            }
            Console.WriteLine("The document is saved in a new format");
        }
    }
}
