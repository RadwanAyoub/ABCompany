using ABCompany.Complaint.Factories;
using ABCompany.Complaint.Repository;
using ABCompany.Complaint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCompany.Complaint.Mediators
{
    public class AdminMediator : IAdminMediator
    {
        private readonly IDataModelService _dataModelService;
        private readonly IAdminFactory _adminFactory;

        public AdminMediator(IDataModelService dataModelService, IAdminFactory adminFactory)
        {
            _dataModelService = dataModelService;
            _adminFactory = adminFactory;
        }

        public AdminViewModel HandleAdminPage()
        {
            var users = _dataModelService.GetUsers();
            var complaints = _dataModelService.GetComplaints();

            return _adminFactory.GetAdminPage(users, complaints);
        }
    }
}