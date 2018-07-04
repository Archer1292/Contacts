using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts.Models
{
    public class Contact
    {
        public int Id{ get; set; }  
        [Required(ErrorMessage ="This field are required")]
        [StringLength(128, MinimumLength = 1, ErrorMessage = "The length of the string must be less than 128 characters")]
        public String FullName { get; set; }

        [Required(ErrorMessage = "This field are required")]
        [StringLength(128, MinimumLength = 6, ErrorMessage = "The length of the string must be betwin 6 and 128 characters")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Incorrect address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field are required")]
        [StringLength(32, MinimumLength = 0, ErrorMessage = "The length of the string must be less than 32 characters")]     
        [RegularExpression(@"^\+?\d[\d -]*$", ErrorMessage = "Phone is not valid.")]       
        public string Phone { get; set; }
    
    }
}