using System;
using System.Collections.Generic;
using System.Text;

namespace TallerWeb.Common.Responses
{
    public class ChurchResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MeetingResponse> Meetings { get; set; }
        public int MeetingsNumber => Meetings == null ? 0 : Meetings.Count;
    }
}
