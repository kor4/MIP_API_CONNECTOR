namespace MIP_API_CONNECTOR.Models
{
    public class SdkDocument
    {
        public Guid Id { get; set; } 
        public string? Name { get; set; }
        public string? Text { get; set; }
        public string Owner { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string Source { get; set; } = null!;

    }
}
