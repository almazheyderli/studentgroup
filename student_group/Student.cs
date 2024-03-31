using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_group
{
    internal class Student
    {
        public Student(string fullName,string groupNo,double avgPoint)
        {
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }
        public string FullName;
       public string GroupNo;
       public double AvgPoint;
    }
}
