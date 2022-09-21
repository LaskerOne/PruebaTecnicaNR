using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class UsersBC
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string firstName { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string secondName { get; set; }  

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string lastName { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string lastName2 { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string phone { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string email { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string address { get; set;}

        [Required]
        public byte age { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string genre { get; set; }
    }
}
