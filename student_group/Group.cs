
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace student_group
{
    internal class Group
    {
        public Group(string no, int studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;


        }
        public string No;
        public int StudentLimit;
        Student[] Students = new Student[] { };


        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("yer yoxdu");



            }
        }
        public void CheckStudents()
        {
            if (Students.Length > 0)
            {
                foreach (Student student in Students)
                {
                    Console.WriteLine(student.FullName, student.GroupNo, student.AvgPoint);
                }
            }
            else
            {
                Console.WriteLine("telebe yoxdur");
            }




        }
        public void FindStudents(string fullname)
        {

            bool check = false;

            foreach (Student student in Students)
            {
                if (student.FullName.ToLower() ==fullname.ToLower())
                {
                    Console.WriteLine("Ad: " + student.FullName + ", Qrup: " + student.GroupNo + ", Ortalama: " + student.AvgPoint);
                    check= true;
                }
            }



            if (!check)
            {
                Console.WriteLine("Axtarilan ad soyada uygun telebe tapilmadi");
            }
        }


    

    }
}

