using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExample.Interfaces;
using CoreExample.Models;
using CoreExample.Options;
using Microsoft.Extensions.Options;

namespace CoreExample.Implementations
{
    public class UserService : IUserService
    {
        private readonly IOptions<SomeConfig> someConfig;
        private readonly IOptions<SomeNestedConfig> someNestedConfig;

        public UserService(IOptions<SomeConfig> someConfig, IOptions<SomeNestedConfig> someNestedConfig)
        {
            this.someConfig = someConfig;
            this.someNestedConfig = someNestedConfig;
        }

        public int Create(User user)
        {
            throw new NotImplementedException();
        }

        public bool Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
