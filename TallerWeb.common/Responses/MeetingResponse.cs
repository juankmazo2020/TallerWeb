using System;
using System.Collections.Generic;
using System.Text;

namespace TallerWeb.Common.Responses
{
    public class MeetingResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<AssistanceResponse> Assistances { get; set; }
        public int AssistancesNumber => Assistances == null ? 0 : Assistances.Count;
    }
}
