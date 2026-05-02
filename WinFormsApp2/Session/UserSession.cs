using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNI__PLANNER.Models;

namespace UNI__PLANNER.Session
{
    public static class UserSession
    {
        public static Student CurrentStudent { get; set; }
        public static DateTime Date { get; set; }
        public static string Section { get; internal set; }
    }
}
