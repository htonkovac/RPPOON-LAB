using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }

}
