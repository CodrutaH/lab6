﻿using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.DTOs
{
    public class GetUserDto
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public static GetUserDto FromUser(User user)
        {
            return new GetUserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
            };
        }
    }
}
