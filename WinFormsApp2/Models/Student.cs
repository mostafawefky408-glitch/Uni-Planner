using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNI__PLANNER.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Section { get; set; }

        public Student(string name, string id, string section)
        {
            Name = name;
            ID = id;
            Section = section;
        }
    }
}
