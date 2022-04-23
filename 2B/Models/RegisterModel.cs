using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _2B.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Поле Email обязательно для заполнения!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле Возраст обязательно для заполнения!")]
        public int UserAge { get; set; }
        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Поле подтверждения пароля обязательно для заполнения!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}