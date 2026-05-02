using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNI__PLANNER.Services
{
    public class UniversityData
    {
        public List<string> SubjectNames = new List<string>
        {
            "OOP","IT","IS","Logic","Calculus","Probability"
        };

        public Dictionary<string, string> Doctors = new Dictionary<string, string>
        {
            {"OOP","Dr. Mohamed Haggag"},
            {"IT","Dr. Hala Okasha"},
            {"IS","Dr. Haitham"},
            {"Logic","Dr. Mahfouz"},
            {"Calculus","Dr. Sherif"},
            {"Probability","Dr. Rasha"}
        };

        public Dictionary<int, Dictionary<string, string>> Assistants =
            new Dictionary<int, Dictionary<string, string>>
        {
            {
                31, new Dictionary<string, string>
                {
                    {"OOP","Omar Islam"},
                    {"IT","Kholoud Amer"},
                    {"IS","Alaa"},
                    {"Logic","ElAtwi"},
                    {"Probability","Zaid"},
                    {"Calculus","Abdelsalam"}
                }
            }
        };
    }
}