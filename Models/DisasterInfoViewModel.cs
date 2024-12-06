using DisasterAid.Constants;

namespace DisasterAid.Models
{
    public class DisasterInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string Type { get; set; }
        public string Organiser { get; set; }
        public string Description { get; set; } 
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        
        public DisasterInfoViewModel(int id, string name, DateTime startingTime, string type, string organiser, string description, string location, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Start = startingTime.ToString(ModelConstants.DateFormat);
            Type = type;
            Organiser = organiser;
            Description = description;
            Location = location;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
