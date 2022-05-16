using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCore_MVC_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCore_MVC_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.EmployeeMVCTable.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeMVcClass empclass)
        {
            if(ModelState.IsValid)
            {
                _db.Add(empclass);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(empclass);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            var getemployeedetails = await _db.EmployeeMVCTable.FindAsync(id);
            return View(getemployeedetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeMVcClass emclass)
        {
            if(ModelState.IsValid)
            {
                _db.Update(emclass);
               await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(emclass);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getemployeedetails = await _db.EmployeeMVCTable.FindAsync(id);
            return View(getemployeedetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getemployeedetails = await _db.EmployeeMVCTable.FindAsync(id);
            return View(getemployeedetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            
            var getemployeedetails = await _db.EmployeeMVCTable.FindAsync(id);
            _db.EmployeeMVCTable.Remove(getemployeedetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
            //int result = _db.SaveChanges();

            //string url = this.Url.Action("Index", "Employee");

            //return Json(url);
        }
    } 
}
