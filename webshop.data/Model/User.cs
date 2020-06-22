using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ch.gibz.m151.demo.data.Model
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        ICollection<UserToGroup> UserToGroup { get; set; }
    }
}
