namespace src.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string CourseId { get; set; } = null!;
        public int? Score { get; set; }
    }
}