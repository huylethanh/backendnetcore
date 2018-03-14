using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Share.Intefaces.Repositories;

namespace WebApplication1.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository postRepository;

        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var list = this.postRepository.GetList(110);
            return View(list);
        }

        public IActionResult Edit(int postid, string type)
        {
            return View(postid);
        }
    }
}