using System;

namespace HappyPet.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int VisitorID { get; set; }
        public string Pet { get; set; }
        public int DoctorID { get; set; }
        public int HospitalID { get; set; }
        public string Notes { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}
