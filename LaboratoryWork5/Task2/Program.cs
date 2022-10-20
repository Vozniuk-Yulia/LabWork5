using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadPupil badPupil = new BadPupil("John");
            GoodPupil goodPupil = new GoodPupil("Ann");
            ExcelentPupil excelentPupil = new ExcelentPupil("Bob");
            ExcelentPupil excelentPupil1 = new ExcelentPupil("Tom");
            ClassRoom classRoom = new ClassRoom(badPupil, goodPupil, excelentPupil, excelentPupil1);
            classRoom.ShowStudyInfo();
            classRoom.ShowReadInfo();
            classRoom.ShowWriteInfo();
            classRoom.ShowRelaxInfo();
        }
    }
}