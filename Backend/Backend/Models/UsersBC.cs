using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Backend.Models
{
    public class UsersBC
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(7), MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string document { get; set; }

        [Required, MinLength(3), MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string firstName { get; set; }

        [AllowNull]
        [Column(TypeName = "varchar(25)")]
        public string secondName { get; set; }  

        [Required, MinLength(3), MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string lastName { get; set; }

        [AllowNull]
        [Column(TypeName = "varchar(25)")]
        public string lastName2 { get; set; }

        [AllowNull]
        [Column(TypeName = "varchar(15)")]
        public string phone { get; set; }

        [AllowNull]
        [Column(TypeName = "varchar(40)")]
        public string email { get; set; }

        [Required,MinLength(15), MaxLength(40)]
        [Column(TypeName = "varchar(40)")]
        public string address { get; set;}

        [Required, Range(15,82)]
        public int age { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string genre { get; set; }
    }
}
