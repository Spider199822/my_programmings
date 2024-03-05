using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strongly_Example.Models
{
    public static class Repository
    {
        public static List<Person> people = new List<Person>()
        {
             new Person(){ID = 1 , Name = "Iman madeny" , Email = "iman@madeny.com", WebSite = "www.toplearn.com"},
             new Person(){ID = 2 , Name = "Sara mohammadi" , Email = "sara@yahoo.com", WebSite = "www.topdev.ir"},
             new Person(){ID = 3 , Name = "Reza mirzaei" , Email = "Reza@gmail.com", WebSite = "www.barnamenevisan.org"}
        }; 
    }
}