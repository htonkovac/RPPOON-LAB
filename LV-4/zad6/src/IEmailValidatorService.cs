using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }

}
