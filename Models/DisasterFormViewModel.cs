using DisasterAid.Constants;
using System.ComponentModel.DataAnnotations;

namespace DisasterAid.Models
{
    public class DisasterFormViewModel
    {
        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        [StringLength(ModelConstants.DisasterNameMaximumLength, MinimumLength = ModelConstants.DisasterNameMinimumLength, ErrorMessage = ModelConstants.StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        [StringLength(ModelConstants.DisasterDescriptionMaximumLength, MinimumLength = ModelConstants.DisasterDescriptionMinimumLength, ErrorMessage = ModelConstants.StringLengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        public string Start { get; set; } = string.Empty;

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        public string End { get; set; } = string.Empty;

        public string? NewType { get; set; }

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        public int TypeId { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        public List<DisasterTypeViewModel> Types { get; set; } = new List<DisasterTypeViewModel>();
    }
}
