using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Person
    {
        public string Name;
        public string MiddleName;
        public string LastName;
        public DateTime Birthday;
        public Gender Gender;
        public bool IsMariaged;



        public Person(string name, string middleName, string lastName, DateTime birthday, Gender gender, bool isMariaged)
        {
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            Birthday = birthday;
            Gender = gender;
            IsMariaged = isMariaged; 
        }
    }

    enum Gender
    {
        MAN, 
        WOMAN
    }
}
