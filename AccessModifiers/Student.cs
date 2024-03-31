using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Student
    {
        public string FullName { get; set; }
        public int GroupNo {  get; set; }
        public double AvgPoint {  get; set; }
        public Student(string fullName, int groupNo, double avgPoint)
        { 
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;

        }

    }
}
