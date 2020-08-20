using ABCompany.DataModel.Enum;
using System;

namespace ABCompany.DataModel.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public WorkflowState State { get; set; }
    }
}