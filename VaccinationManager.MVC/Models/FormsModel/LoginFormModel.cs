using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationManager.MVC.Models.FormsModel
{
    public class LoginFormModel
    {
        public int Id { get; set; }
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordIn { get; set; }
    }
}
