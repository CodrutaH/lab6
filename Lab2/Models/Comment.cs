﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool Important { get; set; }

        public Expense Expense { get; set; }

        public User Owner { get; set; }

       // public int ExpenseId { get; set; }
    }
}
