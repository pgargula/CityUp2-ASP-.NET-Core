using System.Collections.Generic;
using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.CommentService
{
    public interface ICommentService
    {
        Task AddComment(Comment comment);
        Task AddCommentResponse(CommentResponse commentResponse);
        Task<IEnumerable<Comment>> GetComments(int applicationId);
        Task<IEnumerable<Comment>> GetUserComments(int userId);
    }
}