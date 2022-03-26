namespace DAL
{
    using System.ComponentModel.DataAnnotations;
    public class UserMetaData
    {
        [Display(Name = "عنوان نقش")]
        public int UserID { get; set; }

        [Display(Name ="")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ActiveCode { get; set; }
        public bool IsActive { get; set; }
    }
}