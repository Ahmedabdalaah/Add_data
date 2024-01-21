using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Add_data
{
    internal class AddStudent
    {
        public void addS(string firstName, string lastName, string age, string email)
        {
            try
            {
                StreamWriter stream = new StreamWriter("student.txt", true);
                stream.WriteLine(" first name: " + firstName);
                stream.WriteLine(" last name : " + lastName);
                stream.WriteLine(" age : " + age);
                stream.WriteLine("email: " + email);
                stream.Close();
                Console.WriteLine("Done :success ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool chekN(string name)
        {
            string expression = "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$";
            if (Regex.IsMatch(name, expression))
            {
                return true;
            }
            else return false;
        }
        public bool checkAge(string age)
        {
            Regex re = new Regex("\\d");
            if (re.IsMatch(age))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

