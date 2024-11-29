using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DisasterAid.Constants.ModelConstants;

namespace DisasterAid.Data
{
    public class Disaster
    {
        [Key]
        [Comment("Unique Identifier for the disaster")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DisasterNameMaximumLength)]
        [Comment("Name of the disaster")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DisasterDescriptionMaximumLength)]
        [Comment("Description of the disaster")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(IdentityUserIdMaxLength)]
        [Comment("Identifier of the organiser")]
        public string OrganiserId { get; set; } = string.Empty;

        [ForeignKey(nameof(OrganiserId))]
        public IdentityUser Organiser { get; set; } = null!;

        [Required]
        [Comment("Date when the disaster was created")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Start date of the disaster")]
        public DateTime Start { get; set; }

        [Required]
        [Comment("End date of the disaster")]
        public DateTime End { get; set; }

        [Required]
        [Comment("Type of the disaster")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public DisasterType Type { get; set; } = null!;

        [Comment("Indicates if the disaster is active or not")]
        public bool IsActive { get; set; }

        public IList<DisasterParticipant> DisasterParticipants { get; set; } = new List<DisasterParticipant>();
    }
}
