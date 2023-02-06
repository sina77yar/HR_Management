using HR_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto:BaseDTO
    {
        public bool? Approved { get; set; }

    }
}
