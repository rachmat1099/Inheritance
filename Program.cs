using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rachmat", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();

            Student student = new Student("Rachmat", 20, "19.11.2638", "rachmat.rachmat@students.@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
