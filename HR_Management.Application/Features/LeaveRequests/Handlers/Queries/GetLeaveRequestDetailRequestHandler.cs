using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.LeaveRequests.Requests.Queries;
using HR_Management.Application.Features.LeaveRequests.Requests;
//using HR_Management.Application.Features.LeaveRequests.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Management.Application.DTOs.LeaveRequest;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaverequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaverequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaverequest = await _leaveRequestRepository.Get(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaverequest);
        }
    }
}
