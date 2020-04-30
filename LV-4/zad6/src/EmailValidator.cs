using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    class EmailValidator : IEmailValidatorService
    {       
        public bool IsValidAddress(String candidate)
        {
            return candidate.Contains("@") && (candidate.EndsWith(".com") || candidate.EndsWith(".hr"));
        }

    }
}
