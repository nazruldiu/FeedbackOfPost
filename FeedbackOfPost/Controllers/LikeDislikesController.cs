using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FeedbackOfPost.Data;
using FeedbackOfPost.Models;

namespace FeedbackOfPost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeDislikesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public LikeDislikesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/LikeDislikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LikeDislike>>> GetLikeDislike()
        {
            return await _context.LikeDislike.ToListAsync();
        }

        // GET: api/LikeDislikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LikeDislike>> GetLikeDislike(int id)
        {
            var likeDislike = await _context.LikeDislike.FindAsync(id);

            if (likeDislike == null)
            {
                return NotFound();
            }

            return likeDislike;
        }

        // PUT: api/LikeDislikes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLikeDislike(int id, LikeDislike likeDislike)
        {
            if (id != likeDislike.Id)
            {
                return BadRequest();
            }

            _context.Entry(likeDislike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikeDislikeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LikeDislikes
        [HttpPost]
        public async Task<ActionResult<LikeDislike>> PostLikeDislike(LikeDislike likeDislike)
        {
            _context.LikeDislike.Add(likeDislike);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLikeDislike", new { id = likeDislike.Id }, likeDislike);
        }

        // DELETE: api/LikeDislikes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LikeDislike>> DeleteLikeDislike(int id)
        {
            var likeDislike = await _context.LikeDislike.FindAsync(id);
            if (likeDislike == null)
            {
                return NotFound();
            }

            _context.LikeDislike.Remove(likeDislike);
            await _context.SaveChangesAsync();

            return likeDislike;
        }

        private bool LikeDislikeExists(int id)
        {
            return _context.LikeDislike.Any(e => e.Id == id);
        }
    }
}
