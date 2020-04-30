using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    class PasswordValidator : IPasswordValidatorService
    {
        public int MinLength { get; private set; }
        public PasswordValidator(int minLength)
        {
            this.MinLength = minLength;
        }
        public bool IsValidPassword(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return IsLongEnough(candidate) && ContainsDiffrentCharacterTypes(candidate);
        }
        private bool IsLongEnough(String candidate)
        {
            return candidate.Length >= this.MinLength;
        }
        private bool ContainsDiffrentCharacterTypes(string candidate)
        {
            bool hasLower = false, hasUpper = false, hasNumber = false; foreach (char c in candidate)
            {
                if (char.IsDigit(c)) hasNumber = true; if (char.IsUpper(c)) hasUpper = true; if (char.IsLower(c)) hasLower = true;
            }
            return (hasLower && hasUpper && hasNumber);
        }
    }
}
