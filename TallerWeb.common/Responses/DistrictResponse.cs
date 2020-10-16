using System;
using System.Collections.Generic;
using System.Text;

namespace TallerWeb.Common.Responses
{
    public class DistrictResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ChurchResponse> Churches { get; set; }
        public int ChurchesNumber => Churches == null ? 0 : Churches.Count;
    }
}
