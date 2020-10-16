using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerWeb.Web.Data.Entities
{
    public class Church
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the added field {0} must contain less than {1} characters")]
        [Required]
        public string Name { get; set; }

        public ICollection<Meeting> Meetings { get; set; }

        [DisplayName("Meetings Number")]
        public int MeetingsNumber => Meetings == null ? 0 : Meetings.Count;

        public ICollection<User> Users { get; set; }

        [DisplayName("Users Number")]
        public int UsersNumber => Users == null ? 0 : Users.Count;

        [JsonIgnore]//When request is generated in Json, dont save change
        [NotMapped]//The Properity Will not save in database
        public int IdDistrict { get; set; }//Knowing which district the church belongs to

        [JsonIgnore]
        public District District { get; set; }
    }
}
