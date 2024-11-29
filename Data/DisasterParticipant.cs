using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterAid.Data
{
    [PrimaryKey(nameof(DisasterId), nameof(HelperId))]
    public class DisasterParticipant
    {
        [Comment("Identifier of the disaster")]
        public int DisasterId { get; set; }

        [ForeignKey(nameof(DisasterId))]
        public Disaster Disaster { get; set; } = null!;

        [Comment("Identifier of the helper")]
        public string HelperId { get; set; } = string.Empty;

        [ForeignKey(nameof(HelperId))]
        public IdentityUser Helper { get; set; } = null!;
    }
}
