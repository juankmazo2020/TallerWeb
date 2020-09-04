using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerWeb.Common.Entities
{
    public class Church
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the added field {0} must contain less than {1} characters")]
        [Required]
        public string Name { get; set; }

        [JsonIgnore]//When request is generated in Json, dont save change
        [NotMapped]//The Properity Will not save in database
        public int IdDistrict { get; set; }//Knowing which district the church belongs to

        [JsonIgnore]

        public District District { get; set; }
    }
}
