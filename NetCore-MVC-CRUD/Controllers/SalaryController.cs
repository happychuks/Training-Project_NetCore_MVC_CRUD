using Microsoft.AspNetCore.Mvc;
using NetCore_MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_MVC_CRUD.Controllers
{
    public class SalaryController : Controller
    {
        private ApplicationDbContext _db;
        public SalaryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            object displaydata = _db.EmployeeSalaryList;
            return View(displaydata);
        }
        public IActionResult Create(int EmployeeID)
        {
            try
            {

                if (EmployeeID > 0)
                {
                    EmployeeMVcClass empclass = returnEmployeeMVcTable(EmployeeID);
                    ViewBag.EmployeeID = EmployeeID;
                    ViewBag.Names = (empclass.Surname + " " + empclass.FirstName + " " + empclass.MiddleName);

                    return View();
                }

            }
            catch (Exception ex)
            {


            }

            return View();
        }
        public IActionResult SaveRecord(EmployeeSalaryScale esScale)
        {
            try
            {
                if (esScale.AmountPaid > 0)
                {

                    _db.Add(esScale);
                    int result = _db.SaveChanges();
                    List();
                    return View("List");
                }


            }
            catch (Exception ex)
            {


            }

            return View("Create");
        }
        private EmployeeMVcClass returnEmployeeMVcTable(int EmployeeID)
        {
            EmployeeMVcClass employeeInfo = _db.EmployeeMVCTable.Where(i => i.EmployeeID == EmployeeID).FirstOrDefault();

            return employeeInfo;
        }
        public IActionResult deleteSalaryRecord(int EmployeeID)
        {
            EmployeeSalaryScale esScale = _db.EmployeeSalaryList.Where(i => i.EmployeeID == EmployeeID).FirstOrDefault();
            _db.Remove(esScale);
            int result = _db.SaveChanges();

            string url = this.Url.Action("List", "Salary");
           
            return Json(url);

        }
    }
}
