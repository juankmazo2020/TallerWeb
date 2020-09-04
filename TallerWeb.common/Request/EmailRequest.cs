using System.ComponentModel.DataAnnotations;

namespace TallerWeb.Common.Request
{
    public class EmailRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
