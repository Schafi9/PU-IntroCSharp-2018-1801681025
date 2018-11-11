using System;
using System.Text;

namespace studentsNameCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] student = System.IO.File.ReadAllLines(@"C:\Users\гроздан\Desktop\kriso1\PU-IntroCSharp-2018-1801681025\PUIntroHomeworks\studentsNameCalculations\StudentsList\std-students-2018.txt");
            int studentSum = 0;
            int smiley = '\u263a';
            System.Console.WriteLine("All full names which sum is bigger than 15000 are: ");
            foreach (string line in student)
            {
                student = line.Split(' ');
                string firstName = student[1];
                string fathersName = student[2];
                string lastName = student[3];
                string fullName = $"{firstName} {fathersName} {lastName}";

                for (int i = 0; i < fullName.Length; i++)
                {
                    studentSum = studentSum + (int)fullName[i];
                }
                if (studentSum > 15000)
                    Console.WriteLine($" {fullName} {(char)smiley} => {studentSum}");
            }
        }
    }
}
