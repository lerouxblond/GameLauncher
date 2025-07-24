using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Helpers
{
    public static class EmailHelper
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            var addr = new MailAddress(email);
            return addr.Address == email;
        }
    }
}
