using System.Text.RegularExpressions;

namespace Services
{
    public static class Validation
    {
        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-z]+\.[a-zA-Z]{2,}$");
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        public static bool IsValidUserName(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName) && Regex.IsMatch(userName, @"^[a-zA-Z_][a-zA-Z0-9._-]*$");
        }

        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z]*$");
        }

        public static bool IsValidAddress(string address)
        {
            return Regex.IsMatch(address, @"^[a-zA-Z0-9.,_@#-]*$");
        }
    }
}