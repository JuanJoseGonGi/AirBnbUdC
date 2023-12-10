using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdc.Application.Implementation.Implementation.Parameters;
using AirBnbUdC.GUI.Mappers.Parameters;
using AirBnbUdC.GUI.Models;
using AirBnbUdC.GUI.Models.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;

namespace AirBnbUdC.GUI.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerApplication app = new CustomerImplementationApplication();

        CustomerMapperGUI mapper = new CustomerMapperGUI();

        // GET: Customer
        public ActionResult Index(string filter="" )
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: Customer/Details/5
        public ActionResult Details(long id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel CustomerModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (CustomerModel == null)
            {
                return HttpNotFound();
            }
            return View(CustomerModel);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,FamilyName,Email,CellPhone,Photo")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                CustomerDTO customerDTO = mapper.MapperT2toT1(customerModel);
                app.CreateRecord(customerDTO);
                return RedirectToAction("Index");
            }

            return View(customerModel);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(long id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel MultimediaTypeModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaTypeModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaTypeModel);
        }

        // POST: Customer/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,FamilyName,Email,CellPhone,Photo")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                CustomerDTO customerDTO = mapper.MapperT2toT1(customerModel);
                app.UpdateRecord(customerDTO);
                return RedirectToAction("Index");
            }
            return View(customerModel);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(long id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerModel customerModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (customerModel == null)
            {
                return HttpNotFound();
            }
            return View(customerModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }

    }
}
