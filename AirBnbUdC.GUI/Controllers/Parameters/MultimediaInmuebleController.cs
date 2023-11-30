using AirbnbUdc.Application.Implementation.Implementation.Parameters;
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
    public class MultimediaInmuebleController : Controller
    {
        private IMultimediaInmuebleApplication app = new MultimediaInmuebleImplementationApplication();

        MultimediaInmuebleMapperGUI mapper = new MultimediaInmuebleMapperGUI();

        // GET: MultimediaInmuebleModels
        public ActionResult Index(string filter = "")
        {
            var list = mapper.MapperT1toT2(app.GetAllRecords(filter));
            return View(list);
        }

        // GET: MultimediaInmuebleModels/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaInmuebleModel MultimediaInmuebleModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaInmuebleModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaInmuebleModel);
        }

        // GET: MultimediaInmuebleModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultimediaInmuebleModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] MultimediaInmuebleModel MultimediaInmuebleModel)
        {
            if (ModelState.IsValid)
            {
                MultimediaInmuebleDTO MultimediaInmuebleDTO = mapper.MapperT2toT1(MultimediaInmuebleModel);
                app.CreateRecord(MultimediaInmuebleDTO);
                return RedirectToAction("Index");
            }

            return View(MultimediaInmuebleModel);
        }

        // GET: MultimediaInmuebleModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaInmuebleModel MultimediaInmuebleModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaInmuebleModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaInmuebleModel);
        }

        // POST: MultimediaInmuebleModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] MultimediaInmuebleModel MultimediaInmuebleModel)
        {
            if (ModelState.IsValid)
            {
                MultimediaInmuebleDTO MultimediaInmuebleDTO = mapper.MapperT2toT1(MultimediaInmuebleModel);
                app.UpdateRecord(MultimediaInmuebleDTO);
                return RedirectToAction("Index");
            }
            return View(MultimediaInmuebleModel);
        }

        // GET: MultimediaInmuebleModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultimediaInmuebleModel MultimediaInmuebleModel = mapper.MapperT1toT2(app.GetRecord(id));
            if (MultimediaInmuebleModel == null)
            {
                return HttpNotFound();
            }
            return View(MultimediaInmuebleModel);
        }

        // POST: MultimediaInmuebleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app.DeleteRecord(id);
            return RedirectToAction("Index");
        }

    }
}