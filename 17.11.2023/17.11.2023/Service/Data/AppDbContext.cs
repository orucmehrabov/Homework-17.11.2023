using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author { Id = 1, Name = "Oruc", Surname = "Mehrabov", Age = 26},
                new Author { Id = 2, Name = "Sahin", Surname = "Movsumzade", Age = 27},
                new Author { Id = 3, Name = "Tural", Surname = "Taqiyev", Age = 29},
                new Author { Id = 4, Name = "Kenan", Surname = "Amiraslanov", Age = 25}
            }; 
        }
    }
}
