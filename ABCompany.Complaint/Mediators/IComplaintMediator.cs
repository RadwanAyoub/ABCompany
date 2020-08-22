using ABCompany.Complaint.ViewModels;

namespace ABCompany.Complaint.Mediators
{
    public interface IComplaintMediator
    {
        IndexViewModel GetIndex();
        UserViewModel GetUserModel(string id);
    }
}
