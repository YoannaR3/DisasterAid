using DisasterAid.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterAid.Data
{
    public class DisasterType
    {
        [Key]
        [Comment("Unique Identifier for the disaster type")]
        public int Id { get; set; }

        [Required]
        [StringLength(ModelConstants.DisasterTypeNameMaximumLength)]
        [Comment("Name of the disaster type")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Disaster> Disasters { get; set; } = new List<Disaster>();
    }
}
