using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Repositories.Repositories;
using Share.Intefaces.Models;
using Share.Intefaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewBackend.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IPostRepository postRepository;
        public UserController(IPostRepository userRepository)
        {
            this.postRepository = userRepository;
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            // var abc = (this.postRepository as PostRepository).GetPosts(110).ToList();
            var abc = this.postRepository.GetList(110);
            return new ObjectResult(abc);
        }

        [HttpGet("GetFree")]
        public IActionResult GetFree()
        {
            var abc = this.postRepository.GetABC();
            return new ObjectResult(abc);
        }

        [HttpGet("hhh")]
        public string getabc()
        {
            return "abc";
        }
    }
}