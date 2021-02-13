using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required"), StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        
        public int EmployerID { get; set; }

        public List<SelectListItem> AllEmployers { get; set; }

        public List<Skill> AllSkills { get; set; }


        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> possibleSkills)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();
            foreach (Employer employer in possibleEmployers)
            {
                selectList.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
      
            AllSkills = possibleSkills;
        }

  

        public AddJobViewModel() { }
    }
}
