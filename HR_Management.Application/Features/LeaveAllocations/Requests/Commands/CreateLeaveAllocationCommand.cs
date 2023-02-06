﻿using HR_Management.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocations.Requests.Commands
{
    public  class CreateLeaveAllocationCommand:IRequest<int>
    {
        public LeaveAllocationDto   LeaveAllocationDto { get; set; }
    }
}
