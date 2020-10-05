﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerWeb.Web.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Required]
        public string Document { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

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

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")] 
        public string ImageFullPath => ImageId == Guid.Empty 
            ? $"https://localhost:44396/images/No_image.png" 
            : $"https://tallerweb.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Profession")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Profession.")]
        [Required]
        public int ProfessionId { get; set; }
        public IEnumerable<SelectListItem> Professions { get; set; }
    }
}