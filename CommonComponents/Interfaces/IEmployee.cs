using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents.Interfaces
{
    public interface IEmployee
    {
        int id { get; set; }
        string employee_name { get; set; }
        long employee_salary { get; set; }
        int employee_age { get; set; }
        string profile_image { get; set; }
        long? employee_annual_salary { get; set; }
    }
}
