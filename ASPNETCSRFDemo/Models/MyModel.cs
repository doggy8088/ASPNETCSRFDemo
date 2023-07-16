using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETCSRFDemo.Models
{
    public class MyModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Reason { get; set; }
    }
}