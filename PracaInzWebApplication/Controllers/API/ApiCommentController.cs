using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Services.CommentService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers.API
{
    [Route("api/[controller]/[action]")]
    public class ApiCommentController : Controller
    {
        private readonly ICommentService _commentService;
        public ApiCommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{userId}")]
        public async Task<IEnumerable<Comment>> GetUserComments(int userId)
        {
            return await _commentService.GetUserComments(userId);    
        }

        
        [HttpGet("{applicationId}")]
        public async Task<IEnumerable<Comment>> GetComments(int applicationId)
        {
            return await _commentService.GetComments(applicationId);
        }

        
        [HttpPost]
        public async Task Add([FromForm]Comment comment)
        {
            await _commentService.AddComment(comment);
        }

        [HttpPost]
        public async Task AddResponse([FromForm]CommentResponse comment)
        {
            await _commentService.AddCommentResponse(comment);
        }



        [HttpDelete("{CmmentId}")]
        public void Delete(int CommentId)
        {
        }
    }
}
