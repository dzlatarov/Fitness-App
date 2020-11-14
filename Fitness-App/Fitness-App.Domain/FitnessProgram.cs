using Fitness_App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_App.Domain
{
    public class FitnessProgram
    {
        public FitnessProgram()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Exercises = new HashSet<Exercise>();
            this.Users = new HashSet<ApplicationUser>();
        }

        public string Id { get; set; }

        public ProgramType ProgramType { get; set; }

        public DateTime Duration { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
