using AdvisorMangementAPI.Models;

namespace AdvisorMangementAPI.Interfaces
{
    public interface IAdvisorRepository
    {
        public Advisor GetAdvisors(int id);
        public Advisor Create(Advisor advisor);

        public List<Advisor> GetAll();

        public void Update(Advisor advisor);

        public void Delete(int id);

    }
}
