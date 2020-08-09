using System;
namespace TestMvcCore.Models
{
    public class TestResults
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public decimal MaxRange { get; set; }
        public decimal MinRange { get; set; }
        public string Details { get; set; }
        public StaffModel StaffId { get; set; }
    }
}
