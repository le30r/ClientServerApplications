using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иван", "Дмитриевич", "Маринин", new DateTime(2001, 4, 25), "Рязань", "+79511163132");
            Student student_ = new Student("Данил", "Васильевич", "Белкин", new DateTime(2001, 6, 28), "Рязань", "+79511163122");


            Group _945 = new Group(945);
            _945.AddStudent(student);
            _945.AddStudent(student_);

            

            _945.GetInfo();

            Console.WriteLine("\n");
            _945.RemoveStudent(student);
            _945.GetInfo();
            Console.WriteLine("\n");

            Console.WriteLine(_945.GetStudent(0));

            Console.ReadKey();
        }
    }
}
