namespace ThalesTest.Data.Models
{
    public class ApiResponse
    {
        public string status { get; set; }
        public IEnumerable<Employee> data { get; set; }
    }
}
