using System.Linq;

namespace ABCompany.Complaint.ViewModels
{
    public class IndexViewModel
    {
        public ComplaintViewModel Complaint { get; set; }
        public bool IsData => Complaint.Complaints.Any();
    }
}