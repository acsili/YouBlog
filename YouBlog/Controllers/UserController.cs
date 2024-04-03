using Microsoft.AspNetCore.Mvc;
using YouBlog.DAL.Interfaces;
using YouBlog.Models;

namespace YouBlog.Controllers
{
    public class UserController : Controller
    {

        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) 
        { 

            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {

            var response = await _userRepository.GetAll();

            return View(response);
        }
    }
}
