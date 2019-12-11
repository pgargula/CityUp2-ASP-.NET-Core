using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly AppDbContext _context;
        public CommentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddComment(Comment comment)
        {
            try
            {
                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddCommentResponse(CommentResponse commentResponse)
        {
            try
            {
                await _context.CommentResponses.AddAsync(commentResponse);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Comment>> GetComments(int applicationId)
        {
            try
            {
                return await _context.Comments
                    .Include(x => x.CommentResponses)
                    .Include(x=>x.User)
                    .Where(x => x.ApplicationId == applicationId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Comment>> GetUserComments(int userId)
        {
            try
            {
                return await _context.Comments.Include(x => x.CommentResponses.Where(y => y.UserId == userId)).Where(x => x.UserId == userId).ToListAsync();/////TODO: cant put where inside include
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
