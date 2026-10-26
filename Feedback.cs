using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string Category { get; set; }

        [Range(1, 5, ErrorMessage = "Select a rating from 1 to 5.")]
        public int Rating { get; set; } = 5;

        [Required(ErrorMessage = "Please enter your comments.")]
        [StringLength(500, MinimumLength = 5)]
        public string Comments { get; set; }
    }
}
