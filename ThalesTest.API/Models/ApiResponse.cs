namespace ThalesTest.API.Models
{
    public class ApiResponse
    {
        public string status { get; set; }
        public IEnumerable<Employee> data { get; set; }
    }
}
