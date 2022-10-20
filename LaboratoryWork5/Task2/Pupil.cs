using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Pupil
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Pupil(string name)
        {
            Name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine("Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }
    }
}
