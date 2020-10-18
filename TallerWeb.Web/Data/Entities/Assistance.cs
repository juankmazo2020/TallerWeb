using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerWeb.Web.Data.Entities
{
    public class Assistance
    {
        public int Id { get; set; }

        [DisplayName("Is Present")]
        public bool IsPresent { get; set; }

        [JsonIgnore]
        public Meeting Meeting { get; set; }

        public User User { get; set; }

        [JsonIgnore]//When request is generated in Json, dont save change
        [NotMapped]//The Properity Will not save in database
        public int IdMeeting { get; set; }//Knowing which district the church belongs to

        [JsonIgnore]//When request is generated in Json, dont save change
        [NotMapped]//The Properity Will not save in database
        public int IdUser { get; set; }//Knowing which district the church belongs to
    }
}
