using System.ComponentModel.DataAnnotations;

namespace GigHub01.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}