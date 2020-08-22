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
        private readonly IDataContext _dataContext;
        private readonly IAdminMediator _adminMediator;

        public AdminController(IAdminMediator adminMediator, IDataContext dataContext)
        {
            _adminMediator = adminMediator;
            _dataContext = dataContext;
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
            DataModel.Models.Complaint complaint = _dataContext.GetComplaints().FirstOrDefault(e => e.Id == id);
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
            DataModel.Models.Complaint complaint = _dataContext.GetComplaints().FirstOrDefault(e => e.Id == id);
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
                _dataContext.GetDbContext().Entry(complaint).State = EntityState.Modified;
                _dataContext.GetDbContext().SaveChanges();
                return RedirectToAction("Index");
            }
            return View(complaint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContext.GetDbContext().Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
