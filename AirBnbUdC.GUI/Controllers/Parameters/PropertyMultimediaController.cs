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
    public class PropertyMultimediaController : Controller
    {
        private IPropertyMultimediaApplication app = new PropertyMultimediaImplementationApplication();

        PropertyMultimediaMapperGUI mapper = new PropertyMultimediaMapperGUI();
        // GET: PropertyMultimediaModels
        public ActionResult Index(string filter = "")
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: PropertyMultimediaModels/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyMultimediaModel PropertyMultimediaModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyMultimediaModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyMultimediaModel);
        }

        // GET: PropertyMultimediaModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyMultimediaModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] PropertyMultimediaModel PropertyMultimediaModel)
        {
            if (ModelState.IsValid)
            {
                PropertyMultimediaDTO PropertyMultimedia = mapper.MapperT2toT1(PropertyMultimediaModel);
                app.CreateRecord(PropertyMultimedia);
                return RedirectToAction("Index");
            }

            return View(PropertyMultimediaModel);
        }

        // GET: PropertyMultimediaModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyMultimediaModel PropertyMultimediaModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyMultimediaModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyMultimediaModel);
        }

        // POST: PropertyMultimediaModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] PropertyMultimediaModel PropertyMultimediaModel)
        {
            if (ModelState.IsValid)
            {
                PropertyMultimediaDTO PropertyMultimediaDTO = mapper.MapperT2toT1(PropertyMultimediaModel);
                app.UpdateRecord(PropertyMultimediaDTO);
                return RedirectToAction("Index");
            }
            return View(PropertyMultimediaModel);
        }

        // GET: PropertyMultimediaModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyMultimediaModel PropertyMultimediaModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (PropertyMultimediaModel == null)
            {
                return HttpNotFound();
            }
            return View(PropertyMultimediaModel);
        }

        // POST: PropertyMultimediaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }
    }
}
