using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;
        private int _studentCount;
        private Student[] _students;

        

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if(value.Length==5 && value[0]>='A' && value[0]<='Z' && value[1]>='A' && value[1]<='Z' && value[2]>='0' && value[2]<='9' && value[3] >= '0' && value[3]<= '9' && value[4] >= '0' && value[4] <= '9')
                {
                    _no = value;
                }
            }
        }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
               if (value>=0 && value <= 20)
                {
                    _studentLimit = value;
                }
            }
        }
       
        public Group(string no, int studentLimit)
        {
            No = no;
            _students = new Student[studentLimit];
            _studentCount = 0;
            StudentLimit = studentLimit;
        }
        public void AddStudent(Student student)
        {
            if (_studentCount < _studentLimit)
            {
                _students[_studentCount] = student;
                _studentCount++;
            }
            else
            {
                Console.WriteLine("Group is full.");
            }

        }
        public void ShowAllStudents()
        {
            Console.WriteLine("Butun telebeler:");
            foreach( var student in _students )
            {
                if( student != null )
                {
                    Console.WriteLine($"FullName:{student.FullName},GroupNo:{student.GroupNo}, AvgPoint:{student.AvgPoint}");
                }

            }
        }
        public void SearchStudents(string searchvalue)
        {
            Console.WriteLine("Axtarisin neticesi:");
            foreach (var student in _students)
            {
                if (student.FullName == searchvalue && student != null)
                {
                    Console.WriteLine($"FullName:{student.FullName},GroupNo:{student.GroupNo}, AvgPoint:{student.AvgPoint}");
                }
            }

        }

    }
}
