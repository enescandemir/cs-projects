using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Session
{
    public static class Session
    {
        public static string JwtToken { get; set; }
        public static string UserRole { get; set; }
        public static string UserName { get; set; }
        public static int UserId { get; set; }
        public static void Clear()
        {
            JwtToken = null;
            UserRole = null;
            UserName = null;
            UserId = 0;
        }

    }

}
