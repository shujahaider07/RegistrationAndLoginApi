using Entities;

namespace Repository.IRepository
{
    public interface IRegistration
    {
        public Task<List<Registration>> GetAllRegistertionAccounts();

        public Task<Registration> AddRegistration(Registration registration);
        public Task<Registration> UpdateRegistration(Registration registration);
        public Task<Registration> DeleteRegistration(Registration registration);
        public Task<Registration> GetCardById(int id);
    }
}
