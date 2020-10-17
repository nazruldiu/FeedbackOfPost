using FeedbackOfPost.Data;
using FeedbackOfPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackOfPost.Repository
{
    public class UnitOfWork
    {
        private readonly AppDBContext context;

        public UnitOfWork(AppDBContext db)
        {
            context = db;
        }

        private GenericRepository<User> userRepository;
        private GenericRepository<Post> postRepository;
        private GenericRepository<Comment> commentRepository;
        private GenericRepository<LikeDislike> likeDislikeRepository;

        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }
        public GenericRepository<Post> PostRepository
        {
            get
            {

                if (this.postRepository == null)
                {
                    this.postRepository = new GenericRepository<Post>(context);
                }
                return postRepository;
            }
        }
        public GenericRepository<Comment> CommentRepository
        {
            get
            {

                if (this.commentRepository == null)
                {
                    this.commentRepository = new GenericRepository<Comment>(context);
                }
                return commentRepository;
            }
        }
        public GenericRepository<LikeDislike> LikeDislikeRepository
        {
            get
            {

                if (this.likeDislikeRepository == null)
                {
                    this.likeDislikeRepository = new GenericRepository<LikeDislike>(context);
                }
                return likeDislikeRepository;
            }
        }

        public void Save()
        {
            context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
