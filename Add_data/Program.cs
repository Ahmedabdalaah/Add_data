// See https://aka.ms/new-console-template for more information
using Add_data;

AddProf prof=new AddProf();
AddStudent student = new AddStudent();
AddDepart department = new AddDepart();
AddCourse course = new AddCourse();
Console.WriteLine("Choose an operation :");
Console.WriteLine(" a: add professor");
Console.WriteLine(" b: add student ");
Console.WriteLine(" c: add department");
Console.WriteLine(" d: add course");
try
{
    string choose = Console.ReadLine();
    if (choose == "a")
    {
        Console.WriteLine("Enter first name");
        string frist = Console.ReadLine();
        bool checkFirst = prof.chekN(frist);
        if (checkFirst == true)
        {
         Console.WriteLine("Enter last name");
         string last = Console.ReadLine();
         bool checkLast = prof.chekN(last);
            if ((checkLast == true))
            {
                Console.WriteLine("Enter age ");
                string age = Console.ReadLine();
                bool checkage = prof.checkAge(age);
                if (checkage == true)
                {
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();
                    bool checkEmail = prof.checkEmail(email);
                    if(checkEmail == true)
                    {
                        prof.addP(frist, last, age, email);
                    }
                }
            }
            }
        else
        {
            Console.WriteLine("Invalid data");
        }

        }
    else if (choose == "b")
    {
        Console.WriteLine("Enter first name");
        string frist = Console.ReadLine();
        bool checkFirst = student.chekN(frist);
        if (checkFirst == true)
        {
            Console.WriteLine("Enter last name");
            string last = Console.ReadLine();
            bool checkLast = student.chekN(last);
            if ((checkLast == true))
            {
                Console.WriteLine("Enter age ");
                string age = Console.ReadLine();
                bool checkage = student.checkAge(age);
                if (checkage == true)
                {
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();
                    bool checkEmail = student.checkEmail(email);
                    if (checkEmail == true)
                    {
                        student.addS(frist, last, age, email);
                    }
                }
            }

        }
        else
        {
            Console.WriteLine("Invalid data");
        }

    }
    else if (choose == "c")
    {
        Console.WriteLine("Enter department name");
        string name = Console.ReadLine();
        bool checkName = department.chekNanme(name);
        if (checkName == true)
        {
           department.addDepartment(name);
            }
        else
        {
            Console.WriteLine("Invalid data");
        }
    }
    else if (choose == "d")
    {
        Console.WriteLine("Enter course name");
        string name = Console.ReadLine();
        bool checkName = course.chekNanme(name);
        if (checkName == true)
        {
            course.addCousre(name);
        }
        else
        {
            Console.WriteLine("Invalid data");
        }
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }
}
 
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

