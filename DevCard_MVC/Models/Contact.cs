using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "فیلد اجباری")]
        [MinLength(3, ErrorMessage = "حداقل کاراکتر")]
        [MaxLength(100,ErrorMessage = "بیشترین")]
        public string Name { get; set; }


        [Required(ErrorMessage = "فیلد اجباری")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }

        public int Service { get; set; }

        public string Message { get; set; }
        public SelectList Servieces  { get; set; }
    }
}
