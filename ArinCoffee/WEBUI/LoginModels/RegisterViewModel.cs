using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBUI.LoginModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        //[Required]
        //public string NameSurname { get; set; }
        //public string Userimages { get; set; }
        //public DateTime LastLogin { get; set; }
        //public DateTime UyeDate { get; set; }
        [Required]
        public string Email { get; set; }
        //public int Status { get; set; }
        //public string token { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }
        //public string Lastip { get; set; }
    }
}
