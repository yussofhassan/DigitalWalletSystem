using System;
using System.Text.RegularExpressions;

namespace DWM_v0
{
    internal static class Validator
    {
        // =========================
        // Check Empty Field
        // =========================
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        // =========================
        // Validate Phone Number
        // (Egypt example: 11 digits)
        // =========================
        public static bool IsValidPhone(string phone)
        {
            return phone.Length == 11 && long.TryParse(phone, out _);
        }

        // =========================
        // Validate Password
        // =========================
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 4;
        }

        // =========================
        // Validate Amount
        // =========================
        public static bool IsValidAmount(decimal amount)
        {
            return amount > 0;
        }

        // =========================
        // Check Numeric Input
        // =========================
        public static bool IsNumeric(string input)
        {
            return decimal.TryParse(input, out _);
        }

        // =========================
        // Optional: Name Validation
        // =========================
        public static bool IsValidName(string name)
        {
            return !IsEmpty(name) && name.Length >= 3;
        }
    }
}