using ClinicData.Data;
using ClinicEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicData.Repository
{
    public class PatientRepository : IPatientRepository
    {
        ClinicDbContext _clinicDb;
        public PatientRepository(ClinicDbContext clinicDb)
        {
            _clinicDb = clinicDb;
        }

        public void AddPatient(Patient patient)
        {
            _clinicDb.Add(patient);
            _clinicDb.SaveChanges();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
