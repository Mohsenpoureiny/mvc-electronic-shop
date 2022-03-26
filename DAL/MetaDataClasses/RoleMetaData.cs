using System;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class RoleMetaData
    {   
        [Key]
        public int RoleID { get; set; }
        [Display(Name ="عنوان نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید.")]
        public string RoleTitle { get; set; }
        [Display(Name = "عنوان سیستمی نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        public string RoleName { get; set; }
    }
}
