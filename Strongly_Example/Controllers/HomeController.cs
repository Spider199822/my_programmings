using Strongly_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Strongly_Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Repository.people);
        }
        public ActionResult Detail(int id)
        {
            Person p = Repository.people.Single(person => person.ID == id);
            return View(p);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person person) 
        {
            person.ID = Repository.people.Max(p=>p.ID)+1;
            Repository.people.Add(person);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Person person = Repository.people.SingleOrDefault(p=>p.ID == id);
            if(person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person person) 
        {
            
            int index = Repository.people.FindIndex(p => p.ID == person.ID);
            Repository.people[index] = person;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) 
        {
            int index = Repository.people.FindIndex(p => p.ID == id);
            Repository.people.RemoveAt(index);
            return RedirectToAction("Index");
        }
    }
}