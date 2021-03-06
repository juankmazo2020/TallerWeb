﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TallerWeb.Common.Entities;

namespace TallerWeb.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboProfessions();
        IEnumerable<SelectListItem> GetComboFields();
        IEnumerable<SelectListItem> GetComboDistricts(int fieldId);
        IEnumerable<SelectListItem> GetComboChurches(int districtId);
    }
}
