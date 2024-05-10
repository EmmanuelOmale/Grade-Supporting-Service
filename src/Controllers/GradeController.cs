using Microsoft.AspNetCore.Mvc;
using src.Entities;
using src.Services.Interfaces;

[ApiController]
[Route("[controller]")]
public class GradeController : ControllerBase
{
    private readonly IGradeService _gradeService;

    public  GradeController(IGradeService gradeService)
    {
        _gradeService = gradeService;
    }

    [HttpPost("courses")]
    public async Task<IActionResult> BulkUploadCourses(IEnumerable<Course> courses)
    {
        await _gradeService.UploadCoursesAsync(courses);
        return Ok("Courses uploaded successfully");
    }

    [HttpPost("persons")]
    public async Task<IActionResult> BulkUploadPersonalData(IEnumerable<Person> persons)
    {
        await _gradeService.UploadPersonsAsync(persons);
        return Ok("Personal data uploaded successfully");
    }

    [HttpGet("report/{personId}")]
    public async Task<IActionResult> ReportPersonalProgress(Guid personId)
    {
        var progress = await _gradeService.ReportPersonalProgressAsync(personId);
        if (progress != null)
        {
            return Ok(progress);
        }
        return NotFound("Person not found");
    }
}
