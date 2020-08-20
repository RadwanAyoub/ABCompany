﻿using ABCompany.Complaint.Enum;
using System;

namespace ABCompany.Complaint.Models
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