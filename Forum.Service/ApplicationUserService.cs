﻿using Forum.Data;
using System;
using System.Threading.Tasks;
using forum_app_demo.Data;
using Forum.Data.Models;
using System.Linq;

namespace Forum.Service
{
    public class ApplicationUserService : IApplicationUser
    {
        private ApplicationDbContext _context;

        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetByName(string name)
        {
            return _context.ApplicationUsers.FirstOrDefault(user => user.UserName == name);
        }

        public ApplicationUser GetById(string id)
        {
            return _context.ApplicationUsers.FirstOrDefault(user => user.Id == id);
        }
    }
}
