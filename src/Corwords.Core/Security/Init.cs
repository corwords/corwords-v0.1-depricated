﻿using Corwords.Data.Security;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corwords.Core.Security
{
    public class SecuritySetup
    {
        private UserManager<ApplicationUser> _userManager;

        public SecuritySetup(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public bool Initialize(string email, string username, string password)
        {
            var user = new ApplicationUser { UserName = username };
            var taskResult = _userManager.CreateAsync(user, password);

            return taskResult.Result.Succeeded;
        }
    }
}
