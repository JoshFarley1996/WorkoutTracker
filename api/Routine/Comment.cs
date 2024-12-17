using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Workouts;

namespace api.Routine
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? ExcersizeID {get; set;}
        //Navagation property
        public Excersize? Excersize {get; set;}
        
    }
}