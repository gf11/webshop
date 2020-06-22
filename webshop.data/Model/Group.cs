using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ch.gibz.m151.demo.data.Model
{
    public class Group
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        ICollection<UserToGroup> UserToGroup { get; set; }
        ICollection<PrivilegeToGroup> PrivilegeToGroup { get; set; }
    }
}
