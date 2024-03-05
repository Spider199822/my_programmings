using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace Strongly_Example.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
    }
}