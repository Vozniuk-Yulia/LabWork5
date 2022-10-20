using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        { }

        public override void Study()
        {
            Console.WriteLine($"{Name} study excelent");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} read excelent");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} write excelent");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relax excelent");
        }
    }
}
