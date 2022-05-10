using System;
using System.IO;
using System.Text.RegularExpressions;

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
            fio += " (" + CountWords(fio) + ")";
            string genderAndStatus = gender + ", " + mariageStatus;
            string birthday = "\nДата рождения: " + person.Birthday.Date.ToShortDateString() 
                + " (на момент запуска программы " + GetAge(person.Birthday.Date) + 
                " " + Generate(GetAge(person.Birthday.Date), "год", "года", "лет")+ ")";
            File.AppendAllText(path, "\n \n" + fio);
            File.AppendAllText(path, genderAndStatus);
            File.AppendAllText(path, birthday);

        }

        static string CountWords(string str) 
        {
            int vowel = Regex.Matches(str, @"[уеыаоэяиёю]", RegexOptions.IgnoreCase).Count;
            int consonant = Regex.Matches(str, @"[цкнгшщзхфвпрлджчсмтб]", RegexOptions.IgnoreCase).Count;

            return vowel + " гласных и " + consonant + " согласных звуков";
        }
        static int GetAge(DateTime birthday)
        {
            return DateTime.Now.Subtract(birthday).Days / 365;   
        }

        public static string Generate(int number, string nominativ, string genetiv, string plural)
        {
            var titles = new[] { nominativ, genetiv, plural };
            var cases = new[] { 2, 0, 1, 1, 1, 2 };
            return titles[number % 100 > 4 && number % 100 < 20 ? 2 : cases[(number % 10 < 5) ? number % 10 : 5]];
        }
    }
}
