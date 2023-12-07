﻿using AirbnbUdc.Application.Implementation.Implementation.Parameters;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirBnbUdC.GUI.Mappers.Parameters;
using AirBnbUdC.GUI.Models;
using AirBnbUdC.GUI.Models.Parameters;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AirBnbUdC.GUI.Controllers.Parameters
{
    public class MultimediaTypeController : Controller
    {
        private IMultimediaTypeApplication app = new MultimediaTypeImplementationApplication();

        MultimediaTypeMapperGUI mapper = new MultimediaTypeMapperGUI();

        // GET: MultimediaTypeModels
        public ActionResult Index(string filter = "")
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: MultimediaTypeModels/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaTypeModel MultimediaTypeModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaTypeModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaTypeModel);
        }

        // GET: MultimediaTypeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultimediaTypeModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] MultimediaTypeModel MultimediaTypeModel)
        {
            if (ModelState.IsValid)
            {
                MultimediaTypeDTO MultimediaTypeDTO = mapper.MapperT2toT1(MultimediaTypeModel);
                app.CreateRecord(MultimediaTypeDTO);
                return RedirectToAction("Index");
            }

            return View(MultimediaTypeModel);
        }

        // GET: MultimediaTypeModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaTypeModel MultimediaTypeModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaTypeModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaTypeModel);
        }

        // POST: MultimediaTypeModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] MultimediaTypeModel MultimediaTypeModel)
        {
            if (ModelState.IsValid)
            {
                MultimediaTypeDTO MultimediaTypeDTO = mapper.MapperT2toT1(MultimediaTypeModel);
                app.UpdateRecord(MultimediaTypeDTO);
                return RedirectToAction("Index");
            }
            return View(MultimediaTypeModel);
        }

        // GET: MultimediaTypeModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaTypeModel MultimediaTypeModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaTypeModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaTypeModel);
        }

        // POST: MultimediaTypeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }

    }
}
