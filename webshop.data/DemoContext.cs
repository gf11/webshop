using ch.gibz.m151.demo.data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m151.demo.data
{
    public class DemoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Privilege> Privileges { get; set; }

        public DbSet<UserToGroup> UserToGroups { get; set; }
        public DbSet<PrivilegeToGroup> PrivilegeToGroups { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        { }
    }
}
