using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_18_Coffee_Shop_Part_1.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Regular { get; set; }
        public string Member { get; set; }
    }
}
