using Newtonsoft.Json;
using System.ComponentModel;

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

    }
}
