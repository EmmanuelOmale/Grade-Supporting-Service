using src.Entities;

namespace src.Services.Interfaces
{
    public interface IGradeService
    {
        Task UploadCoursesAsync(IEnumerable<Course> courses);
        Task UploadPersonsAsync(IEnumerable<Person> persons);
        Task<object> ReportPersonalProgressAsync(Guid personId);
    }
}