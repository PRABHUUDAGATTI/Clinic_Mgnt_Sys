using ClinicEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicData.Repository
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        void DeletePatient(int patientId);
        void GetAll();

    }
}
