using CommonComponents.Interfaces;

namespace ThalesTest.Data.Models
{
    public class Employee:IEmployee
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public long employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
        public long? employee_annual_salary { get; set; }
    }
}
