using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TallerWeb.Common.Entities;

namespace TallerWeb.Web.Models
{
    public class MeetingViewModel : Meeting
    {     

        [Required]
        [Display(Name = "Field")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a field.")]
        public int FieldId { get; set; }

        public IEnumerable<SelectListItem> Fields { get; set; }

        [Required]
        [Display(Name = "District")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a district.")]
        public int DistrictId { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }

        [Required]
        [Display(Name = "Church")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a church.")]
        public int ChurchId { get; set; }
        public IEnumerable<SelectListItem> Churches { get; set; }
    }
}
