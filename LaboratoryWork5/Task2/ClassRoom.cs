using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
            pupils.Add(pupil4);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
        }
        public void ShowReadInfo()
        {
            Console.WriteLine("Read");
            foreach (Pupil pupil in pupils)
            {
                pupil.Read();
            }
        }
        public void ShowWriteInfo()
        {
            Console.WriteLine("Write");
            foreach (Pupil pupil in pupils)
            {
                pupil.Write();
            }
        }
        public void ShowStudyInfo()
        {
            Console.WriteLine("Study");
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
        }
        public void ShowRelaxInfo()
        {
            Console.WriteLine("Relax");
            foreach (Pupil pupil in pupils)
            {
                pupil.Relax();
            }
        }
    }
}
