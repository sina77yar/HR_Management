﻿using HR_Management.Application.Presistence.Contracts;
using HR_Management.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? changeApprovalStatus);
    }
}
