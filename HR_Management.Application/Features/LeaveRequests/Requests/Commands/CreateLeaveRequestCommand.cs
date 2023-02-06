using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand:IRequest<int> //نوع خروجی یک عدد هست که مثلا آیدی رکورد اضافه شده می باشد
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
