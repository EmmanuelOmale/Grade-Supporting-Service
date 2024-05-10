using src.Entities;

namespace src.Repository.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task AddCoursesAsync(IEnumerable<Course> courses);
    }
}