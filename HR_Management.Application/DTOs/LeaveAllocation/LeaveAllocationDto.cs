using HR_Management.Application.DTOs.Common;
using HR_Management.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto:BaseDTO
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string Period { get; set; }
    }
}
