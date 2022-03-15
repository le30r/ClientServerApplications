using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class SQL
    {
        public static readonly string INCREASE_ETHNICAL =
            "UPDATE ЭтническийСостав " +
            "SET Численность = Численность + 1100  " +
            "WHERE Страна IN(select Страна " +
                            "FROM vGroupedCountries " +
                            "GROUP BY Страна " +
                            "HAVING COUNT(Язык) >= 2)";

        public static readonly string GET_AVERAGE =
            "SELECT AVG(Численность)" +
            "FROM ЭтническийСостав";

        public static readonly string SELECT_COUNTRIES =
            "SELECT *" +
            "FROM Страны";

        public static readonly string SELECT_ETHICAL =
           "SELECT Страны.Название AS 'Название страны', Языки.Название AS 'Название языка', Год, Численность " + 
            "FROM ЭтническийСостав JOIN Страны ON Страны.Код = Страна JOIN Языки ON Языки.Код = Язык " + 
            "WHERE Языки.Название = @language AND Страны.Название = @country";


        public static readonly string ADD_NEW_LANGUAGE =
            "EXEC addNewCountry @name, @group, @sign_system";

        public static readonly string CHECK_ADDED_LANGUAGE = "SELECT * FROM Языки WHERE Название = @name";
    }



    /* CREATE VIEW vGroupedCountries
            AS
            select Страна, Язык
            FROM ЭтническийСостав
            GROUP BY Страна, Язык*/
}
