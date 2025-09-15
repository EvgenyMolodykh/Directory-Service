namespace Domain
{
    public class Question
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; } 
        public required string Description { get; set; } 
        public List<Answer> Answers { get; set; } = [];
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public required Guid UserId { get; set; }
        public Answer? Solution { get; set; }
    }
     
    public class Answer 
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required string Content { get; set; } = string.Empty;
        public required Question Question { get; set; }
    }
}
