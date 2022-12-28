using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingTask.Models;
using Microsoft.AspNetCore.Identity;

namespace AccountingTask.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public double Money { get; set; }
   
    public List<Consumption> Consumptions { get; set; }
}

