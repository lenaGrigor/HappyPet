using System.Collections.Generic;

namespace HappyPet.Data.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Site { get; set; }
        public string Descriptions { get; set; }
        public List<string> Pictures { get; set; }
        public List<Doctor> Doctors { get; set; }
        public int NumberOfTop { get; set; }
    }
}
