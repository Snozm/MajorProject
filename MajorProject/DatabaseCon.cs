using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    internal class DatabaseCon
    {
        private static string server = @"IDEAPAD-SNOZM";
        public static string conString = @"Data Source=" + server + @"; Initial Catalog=RailwaysProject; Integrated Security=True;";
    }
}
