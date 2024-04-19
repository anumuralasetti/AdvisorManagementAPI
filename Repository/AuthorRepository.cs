using AdvisorMangementAPI.Interfaces;
using AdvisorMangementAPI.Models;
using Microsoft.EntityFrameworkCore;
using AdvisorMangementAPI;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace AdvisorMangementAPI.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public AuthorRepository()
        {
            using (var context = new ApiContext())
            {
                var authors = new List<Author>();
                context.Authors.AddRange(authors);
                context.SaveChanges();
            }
        }
        public List<Author> GetAuthors()
        {
            using (var context = new ApiContext())
            {
                var list = context.Authors
                    .ToList();
                return list;
            }
        }
    }
}