﻿using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries
{
    public class LeaveRequestDetailsDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestinEmployeeId { get; set; }
        public LeaveTypeDto LeaveTytpe { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned{ get; set; }
        public bool? Approved { get; set; }
        public bool Canceled{ get; set; }
    }
}