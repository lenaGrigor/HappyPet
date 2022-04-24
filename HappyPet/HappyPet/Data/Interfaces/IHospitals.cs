using HappyPet.Data.Models;
using System.Collections.Generic;

namespace HappyPet.Data.Interfaces
{
    public interface IHospitals
    {
        IEnumerable<Hospital> Hospitals { get; }
        IEnumerable<Doctor> Doctors { get; set; }
        Hospital GetHospital(int hospitalID);
        bool UpdateHospital(Hospital hospital);
    }
}
