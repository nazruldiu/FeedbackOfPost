using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string PostDescription { get; set; }
        public DateTime PostDateTime { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
