using UNI__PLANNER.Models;
using UNI__PLANNER.Models.Enums.UNI__PLANNER.Models.Enums;

namespace UNI__PLANNER.Services
{
    public class ScheduleManagerLecture
    {
        public Lecture[] GetSchedule(string section, WeekType weekType)
        {
            List<Lecture> lectures = new List<Lecture>();

            if (section.Trim() == "31")
            {
                if (weekType == WeekType.Even) // ✅ Even Week
                {
                    lectures.Add(new Lecture
                    {
                        Day_ = "Saturday",
                        Time_ = "12:20",
                        Subject_ = "Probability",
                        Instructor_ = "Dr.Rasha",
                        Location_ = "Hall 1"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Sunday",
                        Time_ = "10:20",
                        Subject_ = "IS",
                        Instructor_ = "Dr.Haitham",
                        Location_ = "Hall 2"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Sunday",
                        Time_ = "12:20",
                        Subject_ = "IT",
                        Instructor_ = "Dr. Hala Okasha",
                        Location_ = "Hall 3"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Monday",
                        Time_ = "8:30",
                        Subject_ = "Calculus",
                        Instructor_ = "Dr.Sherif",
                        Location_ = "Hall 1"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Monday",
                        Time_ = "10:20",
                        Subject_ = "OOP",
                        Instructor_ = "Dr.Haggag",
                        Location_ = "Hall 1"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Tuesday",
                        Time_ = "8:30",
                        Subject_ = "Logic",
                        Instructor_ = "Dr.Mahfouz",
                        Location_ = "Hall 3"
                    });
                }
                else // ✅ Odd Week
                {
                    lectures.Add(new Lecture
                    {
                        Day_ = "Saturday",
                        Time_ = "9:00",
                        Subject_ = "Probability",
                        Instructor_ = "Dr.Rasha",
                        Location_ = "Online"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Sunday",
                        Time_ = "7:30",
                        Subject_ = "IS",
                        Instructor_ = "Dr.Haitham",
                        Location_ = "Online"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Sunday",
                        Time_ = "9:00",
                        Subject_ = "IT",
                        Instructor_ = "Dr. Hala Okasha",
                        Location_ = "Online"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Monday",
                        Time_ = "9:00",
                        Subject_ = "OOP",
                        Instructor_ = "Dr.Haggag",
                        Location_ = "Online"
                    });

                    lectures.Add(new Lecture
                    {
                        Day_ = "Tuesday",
                        Time_ = "7:30",
                        Subject_ = "Logic",
                        Instructor_ = "Dr.Mahfouz",
                        Location_ = "Online"
                    });
                    lectures.Add(new Lecture
                    {
                        Day_ = "Wednesday",
                        Time_ = "9:00",
                        Subject_ = "Calculus",
                        Instructor_ = "Dr.Sherif",
                        Location_ = "Online"
                    });
                }
            }
            return lectures.ToArray();
        }
    }
}