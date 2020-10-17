using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentDescription { get; set; }
        public DateTime CommentDateTime { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
