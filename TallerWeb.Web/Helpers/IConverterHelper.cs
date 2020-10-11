using TallerWeb.Common.Entities;
using TallerWeb.Web.Models;

namespace TallerWeb.Web.Helpers
{
    public interface IConverterHelper
    {
        Meeting ToMeeting(MeetingViewModel model, bool isNew);

        MeetingViewModel ToMeetingViewModel(Meeting meeting);
    }
}
