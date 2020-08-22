using System;
using System.Linq;
using System.Web.Mvc;
using ABCompany.Complaint.Mediators;
using ABCompany.DataModel;
using ABCompany.DataModel.Models;

namespace ABCompany.Complaint.Controllers
{
    public class UsersController : Controller
    {
        private ABCompanyContext db = new ABCompanyContext();
        private readonly IComplaintMediator _complaintMediator;

        public UsersController(IComplaintMediator complaintMediator)
        {
            _complaintMediator = complaintMediator;
        }

        // GET: User
        public ActionResult Index()
        {
            string id = string.Empty;
            if (Session["idUser"] != null)
            {
                id = Session["idUser"].ToString();
            }

            var model = _complaintMediator.GetUserModel(id);

            return View(model);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataModel.Models.Complaint complaint)
        {
            complaint.Date = DateTime.Today;
            complaint.State = DataModel.Enum.WorkflowState.Pending;
            if (ModelState.IsValid)
            {
                var userId = Session["idUser"]?.ToString();
                if (!string.IsNullOrEmpty(userId))
                    complaint.User = int.Parse(userId);
                else
                {
                    ViewBag.error = "Failed to create new complaint";
                    return RedirectToAction("Create");
                }

                db.Complaints.Add(complaint);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }

        /// <summary>
        /// Registration view
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="user">user informations</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Users.FirstOrDefault(s => s.Email == user.Email);
                if (check == null)
                {
                    try
                    {
                        db.Users.Add(user);
                        db.SaveChanges();

                        var data = db.Users.Where(e => e.Email == user.Email).FirstOrDefault();
                        if (data != null)
                        {
                            Session["idUser"] = data.Id;
                        }

                        Session["FirstName"] = user.FirstName;
                        Session["Email"] = user.Email;

                        return Redirect("/");
                    }
                    catch (Exception ex)
                    {
                        ViewBag.error = "Failed to register please try again later";
                        return View();
                    }

                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }
            }
            else
            {
                ViewBag.error = "Failed to register please try again later";
                return View();
            }
        }

        /// <summary>
        /// Login view
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Check the login credentials
        /// </summary>
        /// <param name="user">user informations</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            if (Email != null && Password != null)
            {
                try
                {
                    var data1 = db.Users.ToList();
                    var data = db.Users
                        .FirstOrDefault(s => s.Email.Equals(Email) && s.Password == Password);
                    if (data != null)
                    {
                        //add session
                        Session["FirstName"] = data.FirstName;
                        Session["Email"] = data.Email;
                        Session["idUser"] = data.Id;

                        if (data.Email == "email@abc.com") return Redirect("/admin");

                        return Redirect(string.Format("{0}{1}", "/Users/Index/", Session["idUser"].ToString()));
                    }
                    else
                    {
                        ViewBag.error = "Login failed";
                        return RedirectToAction("Login");
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.error = "Failed to login please try again later";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                ViewBag.error = "Failed to login please try again later";
                return RedirectToAction("Login");
            }
        }

        /// <summary>
        /// Logout current user
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
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
