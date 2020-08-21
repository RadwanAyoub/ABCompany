using ABCompany.DataModel.Models;
using System.Collections.Generic;

namespace ABCompany.Complaint.ViewModels
{
    public class AdminViewModel
    {
        public ComplaintViewModel Complaint { get; set; }
        public List<User> Users { get; set; }
    }
}