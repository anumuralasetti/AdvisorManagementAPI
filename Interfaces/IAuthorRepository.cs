using AdvisorMangementAPI.Models;

namespace AdvisorMangementAPI.Interfaces
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
    }
}
