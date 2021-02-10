using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using Microsoft.EntityFrameworkCore;


namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerID { get; set; }
        public List<SelectListItem> AllEmployers { get; set; }

        public AddJobViewModel(string name)
        {
            Name = name;
        }
    }
}
