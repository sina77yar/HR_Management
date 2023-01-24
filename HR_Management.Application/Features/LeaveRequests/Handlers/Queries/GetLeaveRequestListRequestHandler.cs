using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.Features.LeaveRequests.Requests.Queries;

using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

       public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request,CancellationToken cancellationToken)
        {
            var LeaveRequestList= await _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(LeaveRequestList);
        }

   
    }

}
