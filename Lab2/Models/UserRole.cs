﻿using System;
using System.Collections.Generic;

namespace Lab2.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<UserUserRole> UserUserRoles { get; set; }

        internal object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}