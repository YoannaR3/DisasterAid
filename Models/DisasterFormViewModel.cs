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

        [Required(ErrorMessage = ModelConstants.RequireErrorMessage)]
        public int TypeId { get; set; }
        public int Id { get; set; }

        public List<DisasterTypeViewModel> Types { get; set; } = new List<DisasterTypeViewModel>();
    }
}
