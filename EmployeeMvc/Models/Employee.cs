using System.ComponentModel.DataAnnotations;

namespace EmployeeMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter an email.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
