using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    class RegistrationValidator : IRegistrationValidator
    {
        private EmailValidator emailValidator = new EmailValidator();
        private PasswordValidator passwordValidator = new PasswordValidator(8);
        public bool IsUserEntryValid(UserEntry entry) {
            return this.emailValidator.IsValidAddress(entry.Email) && this.passwordValidator.IsValidPassword(entry.Password);
        }

    }
}
