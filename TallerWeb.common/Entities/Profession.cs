using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerWeb.Common.Entities
{
    public class Profession
    {
        public int Id { get; set; }

        [MaxLength(70, ErrorMessage = "the added field {0} must contain less than {1} characters")]
        [Required]
        public string Name { get; set; }

        public static IEnumerable<object> Data()
        {
            throw new NotImplementedException();
        }
    }
}
