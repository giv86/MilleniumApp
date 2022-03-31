using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MilleniumApp;
using System.Linq;
using System.Web;

namespace MilleniumApp.Models
{
    public class Person
    {
        [Display(ResourceType = typeof(Resources.Resources), Name = "strName")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldRequired")]
        [StringLength(30, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldMaxLength")]
        //[RegularExpression(@"[a-zA-Z]", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strOnlyLetters")]
        public string Nickname { set; get; }

        [Display(ResourceType = typeof(Resources.Resources), Name = "strAddress")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldRequired")]
        [RegularExpression(@"^[_A-Za-z0-9-]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*(\.[A-Za-z]{2,4})$", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strEmailError")]
        public string EmailAddress { set; get; }
    }
}