using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_HashTables
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int Id, string Name, float GPA)
        {
            this.Id = Id;
            this.Name = Name;
            this. GPA = GPA;
        }
    }
}
