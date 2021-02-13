using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required"), StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required"), StringLength(50, MinimumLength = 3)]
        public string Location { get; set; }


    }
}
