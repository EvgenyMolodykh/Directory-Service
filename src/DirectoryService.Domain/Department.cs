namespace DirectoryService.Domain
{
    public class Department
    {
        private readonly Guid Id;
        public string Name { get; private set; }
        public string Identifier { get; private set; }
        public Guid? ParentId { get; private set; }
        public string Path { get; private set; }
        public int Depth { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

    }

    public class Position
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

    }

    public class Location
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public jsonb Address { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

    }
}
