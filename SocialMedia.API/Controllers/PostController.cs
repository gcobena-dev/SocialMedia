using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infraestructure.Repositories;

namespace SocialMedia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPosts()
        {
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
        }
    }
}