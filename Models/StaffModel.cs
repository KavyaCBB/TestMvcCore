using System;
namespace TestMvcCore.Models
{
    public class StaffModel
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Designation { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public Roles RolesId { get; set; }
        public LoginModel PatientId { get; set; }
        
    }
}
