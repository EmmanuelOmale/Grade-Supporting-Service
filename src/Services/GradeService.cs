using src.Entities;
using src.Repository.Interfaces;
using src.Services.Interfaces;

namespace src.Services
{
    public class GradeService : IGradeService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IPersonRepository _personRepository;

        public GradeService(ICourseRepository courseRepository, IPersonRepository personRepository)
        {
            _courseRepository = courseRepository;
            _personRepository = personRepository;
        }

        public async Task UploadCoursesAsync(IEnumerable<Course> courses)
        {
            await _courseRepository.AddCoursesAsync(courses);
        }

        public async Task UploadPersonsAsync(IEnumerable<Person> persons)
        {
            await _personRepository.AddPersonsAsync(persons);
        }

        public async Task<object> ReportPersonalProgressAsync(Guid personId)
        {
            var person = await _personRepository.GetPersonByIdAsync(personId);
            if (person != null)
            {
                return null;
            }
            return null;
        }
    }
}