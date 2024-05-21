using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2005
{
    internal class Dictionary
    {
        Dictionary<int, string> students;

        public Dictionary()
        {
            students = new Dictionary<int, string>();
        }

        public void Add(int id, string name)
        {
            students.Add(id, name);
        }

        public void Print()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
            Console.WriteLine("****************************************");
        }

        public void UpdateGradeStudent(int id, string grade)
        {
            students[id] = grade;
        }
    }
}
