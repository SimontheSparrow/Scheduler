using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Scheduler.Helpers
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Doctor = "Doctor";
        public static string Patient = "Patient";

        public static List<SelectListItem> GetRoles()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value = Admin},
                new SelectListItem{Value = Doctor},
                new SelectListItem{Value = Patient}


            };
        }

    }
}
