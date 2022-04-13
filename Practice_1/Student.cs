using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practice_1
{
    class Student : IComparable 
    {

        private static int _currentID = 0;
        
        private int _id;
        private string _surname;
        private string _name;
        private string _secondName;
        private DateTime _birthday;
        private string _address;
        private string _phoneNumber;
       

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (StringIsValid(value))
                    _surname = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (StringIsValid(value))
                    _name = value;
            }
        }
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                if (StringIsValid(value))
                    _secondName = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return _birthday.Date;
            }
            set
            {
                if (value < DateTime.Now) _birthday = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                _address = value;
            }
        }
        public string PhoneNumber
        {
            set {
                _phoneNumber = value;
            }
            get
            {
                return _phoneNumber;
            }
        }

        public Student()
        {
            _id = _currentID++;
        }

        public Student(string Name, string SecondName, string Surname, DateTime Birthday, string Address, string PhoneNumber)
        {
            _id = _currentID++;
            this.Name = Name;
            this.SecondName = SecondName;
            this.Surname = Surname;
            this.Birthday = Birthday;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }

        public bool Equals(Student student)
        {
            return student.ID == ID &&
                student.Name == Name &&
                student.Surname == Surname &&
                student.SecondName == SecondName &&
                student.Birthday == Birthday &&
                student.Address == Address &&
                student.PhoneNumber == PhoneNumber;
        }

        public override string ToString()
        {
            return "{ID " + ID + " \nSurname: " +
                Surname + " \nName: " + Name + "; \nSecond name: " + SecondName +  " \nDate of birthday: " + Birthday.Date.ToShortDateString() +
                " \nAddress: " + Address + 
                " \nPhone Number: " + PhoneNumber + " }";
        }

        public static bool StringIsValid(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        public int CompareTo(object obj)
        {
            return Surname.CompareTo(((Student)obj).Surname);
        }
    }
}
