using AutoMapper;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            //شخصی سازی آپدیت
            var LeaveRequest = await leaveRequestRepository.Get(request.Id);
            if(request.LeaveRequestDto != null)
            {
                mapper.Map(request.LeaveRequestDto, LeaveRequest);
                await leaveRequestRepository.Update(LeaveRequest);
            }
            else if(request.ChangeLeaveRequestApprovalDto != null)
            {
                await leaveRequestRepository.ChangeApprovalStatus(LeaveRequest, request.ChangeLeaveRequestApprovalDto.Approved);
            }
            return Unit.Value;

        }
    }
}
