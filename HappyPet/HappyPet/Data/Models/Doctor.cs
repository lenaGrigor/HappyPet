using System.Collections.Generic;

namespace HappyPet.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Photo { get; set; }
        public Hospital Hospital { get; set; }
        public List<string> WorkTime { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
