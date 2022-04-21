namespace Eazy.Tours.Models.Poco
{
    [Index(nameof(email), IsUnique = true)]
    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string name { get; set; }

        [Required(ErrorMessage = "Email field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Phone number field is required")]
        [StringLength(maximumLength: 16, MinimumLength = 9)]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string role { get; set; }
    }
}
