using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagement.ViewModel
{
    public class Viewmodel
    {
        [Required(ErrorMessage = "Content is mandatory", AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Min of 5 Charecters")]
        public string Content { get; set; }
    }
}