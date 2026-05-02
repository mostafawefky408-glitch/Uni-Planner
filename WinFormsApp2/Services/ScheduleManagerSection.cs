using UNI__PLANNER.Models;
using UNI__PLANNER.Models.Enums.UNI__PLANNER.Models.Enums;

namespace UNI__PLANNER.Services
{
    public class ScheduleManagerSection
    {
        public Section[] GetSchedule(string section, WeekType weekType)
        {
            List<Section> sections = new List<Section>();

            if (section.Trim() == "31")
            {
                if (weekType == WeekType.Even) // ✅ Even Week
                {
                    sections.Add(new Section
                    {
                        Day_ = "Saturday",
                        Time_ = "9:00",
                        Subject_ = "Probability",
                        Instructor_ = "Zaid",
                        Location_ = "Online"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Sunday",
                        Time_ = "7:30",
                        Subject_ = "IS",
                        Instructor_ = "Alaa",
                        Location_ = "Online"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Sunday",
                        Time_ = "9:00",
                        Subject_ = "IT",
                        Instructor_ = "Kholoud Amer",
                        Location_ = "Online"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Tuesday",
                        Time_ = "7:30",
                        Subject_ = "Logic",
                        Instructor_ = "ElAtwi",
                        Location_ = "Online"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Wednesday",
                        Time_ = "7:30",
                        Subject_ = "Calculus",
                        Instructor_ = "Abdelsalam",
                        Location_ = "Online"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Wednesday",
                        Time_ = "9:00",
                        Subject_ = "OOP",
                        Instructor_ = "Omar Islam",
                        Location_ = "Online"
                    });
                }
                else
                {
                    sections.Add(new Section
                    {
                        Day_ = "Saturday",
                        Time_ = "10:20",
                        Subject_ = "IS",
                        Instructor_ = "Alaa",
                        Location_ = "B1"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Saturday",
                        Time_ = "12:20",
                        Subject_ = "Probability",
                        Instructor_ = "Zaid",
                        Location_ = "Class Room 4"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Saturday",
                        Time_ = "2:10",
                        Subject_ = "Calculus",
                        Instructor_ = "Abdelsalam",
                        Location_ = "Class Room 4"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Thursday",
                        Time_ = "8:30",
                        Subject_ = "IT",
                        Instructor_ = "Kholoud Amer",
                        Location_ = "B3"
                    });

                    sections.Add(new Section
                    {
                        Day_ = "Thursday",
                        Time_ = "12:20",
                        Subject_ = "OOP",
                        Instructor_ = "Omar Islam",
                        Location_ = "C1"
                    });
                    sections.Add(new Section
                    {
                        Day_ = "Thursday",
                        Time_ = "2:10",
                        Subject_ = "Logic",
                        Instructor_ = "ElAtwi",
                        Location_ = "Class Room 2"
                    });
                }
            }
            return sections.ToArray();
        }
    }
}