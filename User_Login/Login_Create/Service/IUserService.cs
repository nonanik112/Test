using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Create.Service
{
    public class IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}
