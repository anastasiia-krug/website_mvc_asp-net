using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage ="Вам необходимо обязательно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам необходимо обязательно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам необходимо обязательно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам необходимо обязательно ввести почту")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам необходимо обязательно ввести сообщение")]
        public string Message { get; set; }
    }
}
