namespace DisasterAid.Models
{
    public class DisasterDetailsViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Location { get; set; }
        public required string Description { get; set; }
        public required string Start { get; set; }
        public required string End { get; set; }
        public required string CreatedOn { get; set; }
        public required string Organiser { get; set; }
        public required string Type { get; set; }
    }
}
