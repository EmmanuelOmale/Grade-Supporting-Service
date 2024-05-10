using Microsoft.EntityFrameworkCore;
using src.DAL;
using src.Entities;
using src.Repository.Interfaces;

namespace src.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _dbContext;

        public CourseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _dbContext.Courses.ToListAsync();
        }

        public async Task AddCoursesAsync(IEnumerable<Course> courses)
        {
            await _dbContext.Courses.AddRangeAsync(courses);
            await _dbContext.SaveChangesAsync();
        }
    }
}