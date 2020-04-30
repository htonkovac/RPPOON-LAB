using System;
using System.Collections.Generic;
using System.Linq;
namespace Renting
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
