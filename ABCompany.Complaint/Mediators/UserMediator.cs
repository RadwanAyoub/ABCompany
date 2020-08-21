using ABCompany.Complaint.Repository;
using ABCompany.DataModel.Models;
using System.Web.Mvc;

namespace ABCompany.Complaint.Mediators
{
    /// <summary>
    /// The mediator is responsible to handle the services and the logic 
    /// behind the component and return final result to the controller
    /// </summary>
    public class UserMediator : IUserMediator
    {
        private readonly IDataModelService _dataModelServiceInterface;

        public UserMediator(IDataModelService dataModelServiceInterface)
        {
            _dataModelServiceInterface = dataModelServiceInterface;
        }

        public ActionResult HandleLogin(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}