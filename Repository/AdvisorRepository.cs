using AdvisorMangementAPI.Interfaces;
using AdvisorMangementAPI.Models;

namespace AdvisorMangementAPI.Repository
{
    public class AdvisorRepository : IAdvisorRepository
    {
        private List<Advisor> advisors;
        public AdvisorRepository()
        {
            // Initialize with some dummy data
            advisors = new List<Advisor>
            {
                new Advisor { Id = 1, Name = "John Doe", SIN = "123456789", Address = "123 Main St", Phone = "12345678", HealthStatus = 1 },
                new Advisor { Id = 2, Name = "Jane Smith", SIN = "987654321", Address = "456 Elm St", Phone = "87654321", HealthStatus = 2 }
            };
        }

        public Advisor Create(Advisor advisor)
        {
            advisor.Id = advisors.Count + 1;
            advisors.Add(advisor);
            return advisor;
        }


        public List<Advisor> GetAll()
        {
            return advisors;
        }

        public void Update(Advisor advisor)
        {
            var existingAdvisor = advisors.FirstOrDefault(a => a.Id == advisor.Id);
            if (existingAdvisor != null)
            {
                existingAdvisor.Name = advisor.Name;
                existingAdvisor.SIN = advisor.SIN;
                existingAdvisor.Address = advisor.Address;
                existingAdvisor.Phone = advisor.Phone;
                existingAdvisor.HealthStatus = advisor.HealthStatus;
            }
            else
            {
                throw new ArgumentException("Advisor not found");
            }
        }

        public void Delete(int id)
        {
            var advisorToRemove = advisors.FirstOrDefault(a => a.Id == id);
            if (advisorToRemove != null)
            {
                advisors.Remove(advisorToRemove);
            }
            else
            {
                throw new ArgumentException("Advisor not found");
            }
        }

       Advisor IAdvisorRepository.GetAdvisors(int id)
        {
            return advisors.FirstOrDefault(a => a.Id == id);
        }
    }
}
