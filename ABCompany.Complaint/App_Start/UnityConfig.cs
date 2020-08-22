using ABCompany.Complaint.Factories;
using ABCompany.Complaint.Mediators;
using ABCompany.Complaint.Repository;
using ABCompany.DataModel;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ABCompany.Complaint
{
    /// <summary>
    /// Unity package to handle DI - services and containers
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            container.RegisterType<IComplaintMediator, ComplaintMediator>();
            container.RegisterType<IDataModelService, DataModelService>();
            container.RegisterType<IComplaintFactory, ComplaintFactory>();
            container.RegisterType<IAdminMediator, AdminMediator>();
            container.RegisterType<IAdminFactory, AdminFactory>();
            container.RegisterType<IDataContext, ABCompanyContext>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}