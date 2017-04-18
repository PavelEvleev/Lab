using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Заполните имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста заполните email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Вы ввели некорректный email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Ввелите номер")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Пожалуйста, укажите, примите ли вы участие")]
        public bool? WillAttend { get; set; }
    }
}