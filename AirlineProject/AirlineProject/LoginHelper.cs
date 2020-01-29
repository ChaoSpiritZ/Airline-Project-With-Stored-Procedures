using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public static class LoginHelper<T> where T : IUser
    {
        public static void CheckToken(LoginToken<T> token)
        {
            if(token == null)
                throw new EmptyTokenException();
            if(token.User == null)
                throw new EmptyTokenException();
        }
    }
}
