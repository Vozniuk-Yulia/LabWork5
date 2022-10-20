using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        { }

        public override void Study()
        {
            Console.WriteLine($"{Name} study bad");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} read bad");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} write bad");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relax bad");
        }
    }
}
