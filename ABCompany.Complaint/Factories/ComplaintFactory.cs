using ABCompany.Complaint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCompany.Complaint.Factories
{
    public class ComplaintFactory : IComplaintFactory
    {
        public IndexViewModel GenerateIndexViewModel(List<DataModel.Models.Complaint> complaints)
        {
            var indexView = new IndexViewModel();

            if (!complaints.Any()) return indexView;

            indexView.Complaint = new ComplaintViewModel()
            {
                Title = "Previous Complaints",
                Description = "Test Previous Complaint Test Previous Complaints Test Previous ComplaintsTest Previous Complaints",
                Complaints = complaints.Where(e=>e.State.ToString() == DataModel.Enum.WorkflowState.Approved.ToString()).ToList()
            };

            return indexView;
        }
    }
}