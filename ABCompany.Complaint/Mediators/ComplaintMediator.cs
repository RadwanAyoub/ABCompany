using ABCompany.Complaint.Factories;
using ABCompany.Complaint.Repository;
using ABCompany.Complaint.ViewModels;

namespace ABCompany.Complaint.Mediators
{
    /// <summary>
    /// The mediator is responsible to handle the services and the logic 
    /// behind the component and return final result to the controller
    /// </summary>
    public class ComplaintMediator : IComplaintMediator
    {
        private readonly IDataModelService _dataModelServiceInterface;
        private readonly IComplaintFactory _complaintFactory;

        public ComplaintMediator(IDataModelService dataModelServiceInterface, IComplaintFactory complaintFactory)
        {
            _dataModelServiceInterface = dataModelServiceInterface;
            _complaintFactory = complaintFactory;
        }

        /// <summary>
        /// Handle the logic behind home page
        /// </summary>
        /// <returns></returns>
        public IndexViewModel GetIndex()
        {
            var complaints = _dataModelServiceInterface.GetComplaints();
            return _complaintFactory.GenerateIndexViewModel(complaints);
        }

        /// <summary>
        /// Handle the logic behind user page
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserViewModel GetUserModel(string id)
        {
            var complaints = _dataModelServiceInterface.GetComplaints();
            return _complaintFactory.GenerateUserViewModel(complaints, id);
        }
    }
}