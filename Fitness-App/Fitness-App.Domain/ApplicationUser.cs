using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_App.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public FitnessProgram FitnessProgram { get; set; }

        public string FitnessProgramId { get; set; }
    }
}
