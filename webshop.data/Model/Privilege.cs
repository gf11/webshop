using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ch.gibz.m151.demo.data.Model
{
    public class Privilege
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name  { get; set; }

        ICollection<PrivilegeToGroup> PrivilegeToGroup { get; set; }
    }
}
