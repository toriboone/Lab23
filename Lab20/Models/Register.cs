using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace Lab20.Models
{
    public class Register
    {
        [Required]
        [Key]
       public string FirstName { get; set; }
        [Required]
       public string Email { get; set; }
    
    }

}