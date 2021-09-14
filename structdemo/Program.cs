using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structdemo
{

    struct studinfo
    {
        public string name;
        public string course;
        public int studid;
        public int regid;
    }
    class Program
    {
        static void Main(string[] args)
        {
            studinfo s1;
            Console.WriteLine("enter student name,course,student id and registration id:");
            s1.name = Console.ReadLine();
            s1.course = Console.ReadLine();
            s1.studid = Convert.ToInt32(Console.ReadLine());
            s1.regid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student details are:");
            Console.WriteLine("student name is:"+s1.name);
            Console.WriteLine("course is:"+s1.course);
            Console.WriteLine("student ID is:"+s1.studid);
            Console.WriteLine("student registration id is:"+s1.regid);
            Console.ReadLine();

        }
    }
}
