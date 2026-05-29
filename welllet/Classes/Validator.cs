using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace welllet.Classes
{
    internal class Validator
    {
        public static bool IsValidPhone(string phone)
        {
            return phone.Length == 11
                && phone.StartsWith("01")
                && phone.All(char.IsDigit);
        }
        public static bool IsValidAmount(decimal amount)
        {
            return amount > 0;
        }

        public static bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}
