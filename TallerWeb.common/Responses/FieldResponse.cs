using System;
using System.Collections.Generic;
using System.Text;

namespace TallerWeb.Common.Responses
{
    public class FieldResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DistrictResponse> Districts { get; set; }
        public int DistrictsNumber => Districts == null ? 0 : Districts.Count;
    }
}
