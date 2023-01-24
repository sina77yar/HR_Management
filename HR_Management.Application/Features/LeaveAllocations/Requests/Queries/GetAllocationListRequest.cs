using HR_Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetAllocationListRequest:IRequest<List<LeaveAllocationDto>>
    {
    }
}
