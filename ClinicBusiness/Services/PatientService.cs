using ClinicData.Repository;
using ClinicEntity.Models;
using System;

namespace ClinicBusiness
{
    public class PatientService
    {
        IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void AddPatient(Patient patient)
        {
            _patientRepository.AddPatient(patient);
        }
    }
}
