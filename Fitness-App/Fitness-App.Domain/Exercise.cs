using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_App.Domain
{
    public class Exercise
    {
        public Exercise()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public string Complexity { get; set; }

        public FitnessProgram FitnessProgram { get; set; }

        public string FitnessProgramId { get; set; }
    }
}
