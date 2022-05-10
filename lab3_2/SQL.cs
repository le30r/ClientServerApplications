using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class SQL
    {
        //public static readonly string ADD_COUNTRY = "EXEC AddCountry @name, @continent, @capital, @number";
        public static readonly string ADD_COUNTRY = "AddCountry";
        public static readonly string CHECK_ADDED_COUNTRY = "SELECT * " +
                                                            "FROM Страны " +
                                                            "WHERE Название = @name ";
    }
}
