using ABCompany.DataModel.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ABCompany.DataModel.Models
{
    public class Complaint
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public WorkflowState State { get; set; }
        public int User { get; set; }
    }
}