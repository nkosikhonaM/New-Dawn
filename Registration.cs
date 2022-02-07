using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace New_Dawn_Rehabilitation_Center
{
    public class Registration
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Id Number")]
        [DisplayName("ID Number")]
        public int IdNumber { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Surname")]
        public string Surname { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }



        [DataType(DataType.PhoneNumber)]
        [DisplayName("Contact Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Id Number")]
        public string ContactDetails { get; set; }
   

        [DataType(DataType.EmailAddress)]
        [DisplayName("eMail Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter eMail Address")]
        public string EmailAddress { get; set; }



        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Home Address")]
        public string HomeAddress { get; set; }




        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Username")]
        public string Username { get; set; }


        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
   
    }
}