using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcWebApiServiceNestedPayload.Models;

namespace MvcWebApiServiceNestedPayload.Controllers
{
    public class PersonController : ApiController
    {
        List<PersonModel1> people1 = new List<PersonModel1>();
        // GET: api/Person
        public IEnumerable<PersonModel1> Get()
        {
            people1.Add(new PersonModel1 { ID = 1, Name = "Parent 1" });
            people1.Add(new PersonModel1 { ID = 2, Name = "Parent 2" });
            people1.Add(new PersonModel1 { ID = 3, Name = "Parent 3" });

            foreach (PersonModel1 p1 in people1)
            {
                p1.people2 = new List<PersonModel2>();
                p1.people2.Add(new PersonModel2 { ID = 1, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
                p1.people2.Add(new PersonModel2 { ID = 2, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
                p1.people2.Add(new PersonModel2 { ID = 3, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
            }

            return people1;
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
