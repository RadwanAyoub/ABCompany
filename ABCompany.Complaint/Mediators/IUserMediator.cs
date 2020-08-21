using ABCompany.DataModel.Models;
using System.Web.Mvc;

namespace ABCompany.Complaint.Mediators
{
    public interface IUserMediator
    {
        ActionResult HandleLogin(User user);
    }
}
