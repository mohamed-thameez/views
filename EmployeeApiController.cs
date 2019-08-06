using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeApiController : ApiController
    {
        private static EmployeeContext db = new EmployeeContext();

        CRUD<EmployeeContext, Employee> crud = new CRUD<EmployeeContext, Employee>(db); 

        // GET: api/EmployeeApi
        public IEnumerable<string> Get()
        {
            var lst = crud.GetAll();

            return new string[] { "value1", "value2" };
        }

        // GET: api/EmployeeApi/5
        public string Get(string id)
        {
            var res = crud.GetById<string>(id);
            return "value";
        }

        // POST: api/EmployeeApi
        public void Post([FromBody]string value)
        {
            Employee emp = new Employee() { Name = value, CreatedDate = DateTime.Now, CreatedBy = "test", Department = "IT", IsAdmin = false };
            var res = crud.Create(emp);
        }

        // PUT: api/EmployeeApi/5
        public void Put(string id, [FromBody]string value)
        {
            Employee emp = new Employee() { EmpId = Convert.ToString(id), Name = value, CreatedDate = DateTime.Now, CreatedBy = "test", Department = "IT", IsAdmin = false };
            var res = crud.Update<string>(emp,Convert.ToString(id));
        }

        // DELETE: api/EmployeeApi/5
        public void Delete(string id)
        {
            var value = Get(id);
            Employee emp = new Employee() { Name = value, CreatedDate = DateTime.Now, CreatedBy = "test", Department = "IT", IsAdmin = false };
            var res = crud.Delete(emp);
        }
    }
}
