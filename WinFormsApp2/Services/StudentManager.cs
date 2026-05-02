using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNI__PLANNER.Models;

namespace UNI__PLANNER.Services
{
    public class StudentManager
    {
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.txt");

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();

            if (!File.Exists(path))
                return list;

            foreach (var line in File.ReadAllLines(path))
            {
                var data = line.Split(',');
                if (data.Length >= 3)
                    list.Add(new Student(data[0], data[1], data[2]));
            }

            return list;
        }

        public Student Find(string id)
        {
            return GetAll().FirstOrDefault(s =>s.ID == id);
        }

        public void Add(Student s)
        {
            string record = $"{s.Name},{s.ID},{s.Section}\n";
            File.AppendAllText(path, record);
        }
    }
}
