using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        { }

        public override void Study()
        {
            Console.WriteLine($"{Name} study good");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} read good");
        }
        public override void Write()
        {
            Console.WriteLine($"{Name} write good");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Name} relax good");
        }
    }
}
