using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PETSystem
{
    public class ErrorHandle
    {
        bool result;
        int ID;
        float IDT;
        public Boolean CheckEmpty(string input)
        {
            if (input == "")
            {
                return false;
            }
            else
            {
                return true;
            } 
        }

        public Boolean CheckInt(string input)
        {
            if (!int.TryParse(input, out ID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Checkfloat(string input)
        {
            if (!float.TryParse(input, out IDT))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean Checkstring(string input)
        {
           return Regex.IsMatch(input, @"^[a-zA-Z' ']+$");
        }

        public Boolean CheckstringNum(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9' ']+$");
        }

        public Boolean CheckEmail(string input)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(input);
                return addr.Address == input;
            }
            catch
            {
                return false;
            }
        }
        public Boolean CheckDate(string Input)
        {
            var dateFormats = new[] { "dd.MM.yyyy", "dd-MM-yyyy", "dd/MM/yyyy" };
            DateTime scheduleDate;
            bool validDate = DateTime.TryParseExact(
                Input,
                dateFormats,
                DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None,
                out scheduleDate);
            if (validDate)
                return true;
            else
                return false;
        }

        
        //ADD Phone Number Check
        public Boolean CheckphoneNum(string Input)
        {
            
            return Regex.Match(Input, @"^([0-9]{10})$").Success;
            
        }
        public Boolean checkForSQLInjection(string userInput)

        {

            bool isSQLInjection = true;

            string[] sqlCheckList = { "--",

                                       ";--",

                                       ";",

                                       "/*",

                                       "*/",

                                        "@@",

                                        

                                        "char",

                                       "nchar",

                                       "varchar",

                                       "nvarchar",

                                       "alter",

                                       "begin",

                                       "cast",

                                       "create",

                                       "cursor",

                                       "declare",

                                       "delete",

                                       "drop",

                                       "end",

                                       "exec",

                                       "execute",

                                       "fetch",

                                            "insert",

                                          "kill",

                                             "select",

                                           "sys",

                                            "sysobjects",

                                            "syscolumns",

                                           "table",

                                           "update"

                                       };

            string CheckString = userInput.Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)

            {

                if ((CheckString.IndexOf(sqlCheckList[i],

    StringComparison.OrdinalIgnoreCase) >= 0))

                { isSQLInjection = false; }
            }

            return isSQLInjection;
        }
    }
    //Test vir Sam en Henk
}

