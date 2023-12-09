using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirbnbUdc.Application.Implementation.Implementation.Parameters;
using AirBnbUdC.GUI.Mappers.Parameters;
using AirBnbUdC.GUI.Models;
using AirBnbUdC.GUI.Models.Parameters;

namespace AirBnbUdC.GUI.Controllers.Parameters
{
    public class PropertyOwnerController : Controller
    {
        private IPropertyOwnerApplication app = new PropertyOwnerImplementationApplication();

        PropertyOwnerMapperGUI mapper = new PropertyOwnerMapperGUI();

        // GET: PropertyOwnerModels
        public ActionResult Index(string filter = "")
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: PropertyOwnerModels/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyOwnerModel PropertyOwnerModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyOwnerModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyOwnerModel);
        }

        // GET: PropertyOwnerModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyOwnerModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] PropertyOwnerModel PropertyOwnerModel)
        {
            if (ModelState.IsValid)
            {
                PropertyOwnerDTO PropertyOwnerDTO = mapper.MapperT2toT1(PropertyOwnerModel);
                app.CreateRecord(PropertyOwnerDTO);
                return RedirectToAction("Index");
            }

            return View(PropertyOwnerModel);
        }

        // GET: PropertyOwnerModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyOwnerModel PropertyOwnerModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyOwnerModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyOwnerModel);
        }

        // POST: PropertyOwnerModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] PropertyOwnerModel PropertyOwnerModel)
        {
            if (ModelState.IsValid)
            {
                PropertyOwnerDTO PropertyOwnerDTO = mapper.MapperT2toT1(PropertyOwnerModel);
                app.UpdateRecord(PropertyOwnerDTO);
                return RedirectToAction("Index");
            }
            return View(PropertyOwnerModel);
        }

        // GET: PropertyOwnerModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyOwnerModel PropertyOwnerModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyOwnerModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyOwnerModel);
        }

        // POST: PropertyOwnerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }

    }
}
