using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Add_data
{
    internal class AddCourse
    {
        public void addCousre(String name)
        {
            try
            {
                StreamWriter stream = new StreamWriter("course.txt", true);
                stream.WriteLine(" course name: " + name);
                stream.Close();
                Console.WriteLine("Done :success ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool chekNanme(string name)
        {
            string expression = "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$";
            if (Regex.IsMatch(name, expression))
            {
                return true;
            }
            else return false;
        }
    }
}
