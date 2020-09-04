using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TallerWeb.Common.Entities
{
    public class Field
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the added field {0} must contain less than {1} characters")]   //Define the Field length 
        [Required] //To forced add name
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }

        [DisplayName("Districts Number")]
        public int DistrictsNumber => Districts == null ? 0 : Districts.Count;

    }
}
