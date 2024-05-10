using Microsoft.EntityFrameworkCore;
using src.DAL;
using src.Entities;
using src.Repository.Interfaces;

namespace src.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _dbContext;

        public PersonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPersonsAsync(IEnumerable<Person> persons)
        {
            await _dbContext.Persons.AddRangeAsync(persons);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByIdAsync(Guid personId)
        {
            return await _dbContext.Persons.FirstOrDefaultAsync(p => p.PersonId == personId);
        }
    }
}