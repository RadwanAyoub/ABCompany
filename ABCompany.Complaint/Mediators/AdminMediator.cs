using ABCompany.Complaint.Factories;
using ABCompany.Complaint.Repository;
using ABCompany.Complaint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCompany.Complaint.Mediators
{
    /// <summary>
    /// The mediator is responsible to handle the services and the logic 
    /// behind the component and return final result to the controller
    /// </summary>
    public class AdminMediator : IAdminMediator
    {
        private readonly IDataModelService _dataModelService;
        private readonly IAdminFactory _adminFactory;

        public AdminMediator(IDataModelService dataModelService, IAdminFactory adminFactory)
        {
            _dataModelService = dataModelService;
            _adminFactory = adminFactory;
        }

        /// <summary>
        /// Handle the logic behind the admin page
        /// </summary>
        /// <returns></returns>
        public AdminViewModel HandleAdminPage()
        {
            var users = _dataModelService.GetUsers();
            var complaints = _dataModelService.GetComplaints();

            return _adminFactory.GetAdminPage(users, complaints);
        }
    }
}