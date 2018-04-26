using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class User
    {
        [Key]
        public int UId { get; set; }
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }
        [Required]
        public string  PassWord { get; set; }
        public string Role { get; set; }
    }
}