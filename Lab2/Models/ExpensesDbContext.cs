﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Models
{
    public class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {



            builder.Entity<User>(entity =>
            {
                entity.HasIndex(u => u.Username).IsUnique();
            });

            builder.Entity<Comment>()
               .HasOne(e => e.Expense)
               .WithMany(c => c.Comments)
               .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                    .HasMany(e => e.UserUserRoles)
                    .WithOne(c => c.User)
                    .OnDelete(DeleteBehavior.Cascade);
        }

        // DbSet = Repository
        // DbSet = O tabela din baza de date
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserUserRole> UserUserRoles { get; set; }

        public DbSet<UserRole> UserRole { get; internal set; }
    }
}
