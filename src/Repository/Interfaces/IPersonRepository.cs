using src.Entities;

namespace src.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Task AddPersonsAsync(IEnumerable<Person> persons);
        Task<Person> GetPersonByIdAsync(Guid personId);
    }
}