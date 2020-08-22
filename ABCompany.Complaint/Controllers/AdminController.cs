using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ABCompany.Complaint.Factories;
using ABCompany.Complaint.Mediators;
using ABCompany.Complaint.Repository;
using ABCompany.DataModel;

namespace ABCompany.Complaint.Controllers
{
    public class AdminController : Controller
    {
        private ABCompanyContext db = new ABCompanyContext();

        private IAdminMediator _adminMediator { get; }

        public AdminController(IAdminMediator adminMediator)
        {
            _adminMediator = adminMediator;
        }

        /// <summary>
        /// Gets admin page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = _adminMediator.HandleAdminPage();
            return View(model);
        }
       
        /// <summary>
        /// Show complaint details
        /// </summary>
        /// <param name="id">Complaint id</param>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataModel.Models.Complaint complaint = db.Complaints.Find(id);
            if (complaint == null)
            {
                return HttpNotFound();
            }
            return View(complaint);
        }

        /// <summary>
        /// Edit complaint
        /// </summary>
        /// <param name="id">Complaint id</param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataModel.Models.Complaint complaint = db.Complaints.Find(id);
            if (complaint == null)
            {
                return HttpNotFound();
            }
            return View(complaint);
        }

        /// <summary>
        /// Submit action for editing a complaint
        /// </summary>
        /// <param name="complaint">Complaint object</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DataModel.Models.Complaint complaint)
        {
            if (ModelState.IsValid)
            {
                db.Entry(complaint).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(complaint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
