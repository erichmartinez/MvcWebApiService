using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApiServiceNestedPayload.Models
{
    public class PersonModel2
    {
        public int ID { get; set; }
        public int Person1ID { get; set; }
        public String Name { get; set; }
    }
}