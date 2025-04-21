using Core.Utilities.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        AccessToken Login(string email, string password);
        bool Register(string firstName, string lastName, string email, string password);
    }
}
