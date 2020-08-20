using ABCompany.Complaint.Mediator;
using System.Web.Mvc;

namespace ABCompany.Complaint.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComplaintMediator _mediatorComplaint;

        public HomeController(IComplaintMediator mediatorComplaint)
        {
            _mediatorComplaint = mediatorComplaint;
        }

        public ActionResult Index()
        {
            var complaints = _mediatorComplaint.GetComplaints();
            return View();
        }
    }
}