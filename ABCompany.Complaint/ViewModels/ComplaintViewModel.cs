using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCompany.Complaint.ViewModels
{
    public class ComplaintViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<DataModel.Models.Complaint> Complaints { get; set; }
    }
}