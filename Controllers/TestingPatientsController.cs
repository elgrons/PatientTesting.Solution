using Microsoft.AspNetCore.Mvc;  
using PatientTesting.DataAccess;  
using PatientTesting.Models;  
using System;  
using System.Collections.Generic;  
  
namespace PatientTesting.Controllers  
{  
    [Route("api/[controller]")]  
    public class TestingPatientsController : ControllerBase  
    {  
        private readonly IDataAccessProvider _dataAccessProvider;  
  
        public TestingPatientsController(IDataAccessProvider dataAccessProvider)  
        {  
            _dataAccessProvider = dataAccessProvider;  
        }  
  
        [HttpGet]  
        public IEnumerable<TestingPatients> Get()  
        {  
            return _dataAccessProvider.GetPatientRecords();  
        }  
          [HttpPost]  
        public IActionResult Create([FromBody]TestingPatients testingpatients)  
        {  
            if (ModelState.IsValid)  
            {  
                Guid obj = Guid.NewGuid();  
                testingpatients.id = obj.ToString();  
                _dataAccessProvider.AddPatientRecord(testingpatients);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpGet("{id}")]  
        public TestingPatients Details(string id)  
        {  
            return _dataAccessProvider.GetPatientSingleRecord(id);  
        }  
  
        [HttpPut]  
        public IActionResult Edit([FromBody]TestingPatients testingpatients)  
        {  
            if (ModelState.IsValid)  
            {  
                _dataAccessProvider.UpdatePatientRecord(testingpatients);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = _dataAccessProvider.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            _dataAccessProvider.DeletePatientRecord(id);  
            return Ok();  
        }  
    }  
}  