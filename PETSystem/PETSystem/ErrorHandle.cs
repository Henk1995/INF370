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

        public Boolean Checkstring(string input)
        {
           return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        public Boolean CheckstringNum(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
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

        //ADD gender ( M or F )
        //ADD Phone Number Check
    }
}
