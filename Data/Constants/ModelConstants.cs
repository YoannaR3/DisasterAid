namespace DisasterAid.Constants
{
    public static class ModelConstants
    {
        public const int DisasterNameMinimumLength = 3;
        public const int DisasterNameMaximumLength = 100;

        public const int DisasterDescriptionMinimumLength = 10;
        public const int DisasterDescriptionMaximumLength = 500;

        public const int DisasterTypeNameMinimumLength = 3;
        public const int DisasterTypeNameMaximumLength = 50;

        public const string DateFormat = "yyyy-MM-dd H:mm";

        public const string RequireErrorMessage = "The field {0} is required";
        public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
        public const int IdentityUserIdMaxLength = 450; 

    }
}
