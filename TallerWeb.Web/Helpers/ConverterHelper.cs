using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerWeb.Common.Entities;
using TallerWeb.Web.Models;

namespace TallerWeb.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {

        public Meeting ToMeeting(MeetingViewModel model, bool isNew)
        {
            return new Meeting
            {
                Id = isNew ? 0 : model.Id,
                Name = model.Name,
                Date = model.Date,
                Church = model.Church
            };
        }

        public MeetingViewModel ToMeetingViewModel(Meeting meeting)
        {
            return new MeetingViewModel
            {
                Id = meeting.Id,
                Name = meeting.Name,
                Date = meeting.Date,
                Church = meeting.Church
            };
        }
    }
}
