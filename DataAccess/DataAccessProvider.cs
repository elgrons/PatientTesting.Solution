using PatientTesting.Models;  
using System.Collections.Generic;  
using System.Linq;  
  
namespace PatientTesting.DataAccess  
{  
    public class DataAccessProvider: IDataAccessProvider  
    {  
        private readonly PostgreSqlContext _context;  
  
        public DataAccessProvider(PostgreSqlContext context)  
        {  
            _context = context;  
        }  
  
        public void AddPatientRecord(TestingPatients testingpatients)  
        {  
            _context.testingpatients.Add(testingpatients);  
            _context.SaveChanges();  
        }  
  
        public void UpdatePatientRecord(TestingPatients testingpatients)  
        {  
            _context.testingpatients.Update(testingpatients);  
            _context.SaveChanges();  
        }  
  
        public void DeletePatientRecord(string id)  
        {  
            var entity = _context.testingpatients.FirstOrDefault(t => t.id == id);  
            _context.testingpatients.Remove(entity);  
            _context.SaveChanges();  
        }  
  
        public TestingPatients GetPatientSingleRecord(string id)  
        {  
            return _context.testingpatients.FirstOrDefault(t => t.id == id);  
        }  
  
        public List<TestingPatients> GetPatientRecords()  
        {  
            return _context.testingpatients.ToList();  
        }  
    }  
}  