using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_2
{
    class PersonHandler
    {
        static string path = "file.txt";

        public static void AddPersonToFile(Person person)
        {
            string gender;
            string mariageStatus;
            if (person.Gender == Gender.MAN)
            {
                gender = "\nМужчина";
                mariageStatus = person.IsMariaged ? "женат" : "не женат";
            }
            else
            {
                gender = "\nЖенщина";
                mariageStatus = person.IsMariaged ? "замужем" : "не замужем";
            }

            string fio = "ФИО: " + person.LastName + " " + person.Name + " " + person.MiddleName;
            string genderAndStatus = gender + ", " + mariageStatus;
            string birthday = "\nДата рождения: " + person.Birthday.Date.ToShortDateString();
            File.AppendAllText(path, "\n \n" + fio);
            File.AppendAllText(path, genderAndStatus);
            File.AppendAllText(path, birthday);

        }

        string CountWords(fio)
    }
}
