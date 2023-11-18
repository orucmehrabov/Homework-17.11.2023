using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2023.Controllers
{
    internal class AuthorController
    {
        private readonly IAuthorService _authorService;
        public AuthorController() 
        {
            _authorService = new AuthorService();
        }
        public void GetAllByAge()
        {
            int age = 25;
            var response = _authorService.GetAllByAge(age);
            foreach (var item in response)
            {
                string res = $"{item.Name} - {item.Surname}";
                Console.WriteLine(res);
            }
        }
    }
}
