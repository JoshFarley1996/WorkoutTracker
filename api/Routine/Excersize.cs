using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using api.Routine;

namespace api.Workouts
{
    public class Excersize
    {
        public int ExcersizeId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public int Reps { get; set; } //Need to add a constraint to limit numbers 0-99        
        public int PriorRep { get; set; }
        public int NewRepGoal { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment> ();

    }
}