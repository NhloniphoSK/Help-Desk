using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroComm_HelpDesk
{
    class EmailValidation
    {
        // User Email validation 
        public static bool IsValidEmailAddress(string emailAddress)
        {
            return new System.ComponentModel.DataAnnotations
                       .EmailAddressAttribute()
                       .IsValid(emailAddress);
        }
    }
}
