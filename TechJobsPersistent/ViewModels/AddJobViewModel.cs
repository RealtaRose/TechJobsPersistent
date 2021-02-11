using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required"), StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public int EmployerID { get; set; }
        
        public List<SelectListItem> AllEmployers{ get; set; }


        public AddJobViewModel(List<Employer> possibleEmployers)
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
            AllEmployers = selectList;

            
        }

        public AddJobViewModel(string name) 
        {
            Name = name;
        }

        public AddJobViewModel()
        {

        }
    }
}
