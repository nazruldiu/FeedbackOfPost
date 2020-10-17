using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Models
{
    public class LikeDislike
    {
        public int Id { get; set; }
        public bool Like { get; set; }
        public bool DisLike { get; set; }
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [NotMapped]
        public string CommentDescription { get; set; }
        [NotMapped]
        public string PostDescription { get; set; }
        [NotMapped]
        public int LikeCount { get; set; }
        [NotMapped]
        public int DislikeCount { get; set; }
        [NotMapped]
        public string UserName { get; set; }
    }
}
