using Entities.DbContextEntities;
using Entities.ResponseClass;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;

namespace Repository.Repository
{
    public class Registration : IRegistration
    {
        private readonly ApplicationDbContext _context;

        public Registration(ApplicationDbContext _context)
        {
            this._context = _context;
        }



        public Task<Entities.Registration> AddRegistration(Entities.Registration registration)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Registration> DeleteRegistration(Entities.Registration registration)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Entities.Registration>> GetAllRegistertionAccounts()
        {
            try
            {
                return await _context.registrations.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Entities.Registration> GetCardById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Login(string Name, string password)
        {

            Response r = new Response();

            var GetResult = await _context.registrations.Where(x => x.Name == Name && x.Password == password).FirstOrDefaultAsync();

            r.returnObject = GetResult;
            return r;
        }

        public Task<Entities.Registration> UpdateRegistration(Entities.Registration registration)
        {
            throw new NotImplementedException();
        }

      
    }
}
