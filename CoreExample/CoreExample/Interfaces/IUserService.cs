using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExample.Models;

namespace CoreExample.Interfaces
{
    public interface IUserService
    {
        bool Login(User user);

        int Create(User user);
    }
}
