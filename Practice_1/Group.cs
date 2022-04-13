using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Group
    {
        private int _id;

        public SortedSet<Student> Students = new SortedSet<Student>();
        
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }



        public Group()
        {
        }
        public Group(int ID)
        {
            this.ID = ID;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
            
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.ID == id)
                {
                    return student;
                }
            }
            return null;
        }

        

        public void GetInfo()
        {
            Console.WriteLine("Номер группы " + ID);
            foreach (Student student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }


    }
}
