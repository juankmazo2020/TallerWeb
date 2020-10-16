using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerWeb.Web.Data.Entities
{
    public class Meeting
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the added field {0} must contain less than {1} characters")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd dddd}")]
        public DateTime Date { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "0:yyyy/MM/dd dddd}")]
        public DateTime DateLocal => Date.ToLocalTime();

        public ICollection<Assistance> Assistances { get; set; }

        [DisplayName("Assistances Number")]
        public int AssistancesNumber => Assistances == null ? 0 : Assistances.Count;

        [JsonIgnore]//When request is generated in Json, dont save change
        [NotMapped]//The Properity Will not save in database
        public int IdChurch { get; set; }//Knowing which district the church belongs to

        [JsonIgnore]
        public Church Church { get; set; }

    }
}
