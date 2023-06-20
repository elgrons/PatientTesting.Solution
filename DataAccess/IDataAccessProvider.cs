using PatientTesting.Models;  
using System.Collections.Generic;  
  
namespace PatientTesting.DataAccess  
{  
    public interface IDataAccessProvider  
    {  
        void AddPatientRecord(TestingPatients testingpatients);  
        void UpdatePatientRecord(TestingPatients testingpatients);  
        void DeletePatientRecord(string id);  
        TestingPatients GetPatientSingleRecord(string id);  
        List<TestingPatients> GetPatientRecords();  
    }  
}  