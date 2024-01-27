using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetLeaveTypeDetailsHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    
    public GetLeaveTypeDetailsHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

        // Verify that record exists
        if (leaveType == null)
            throw new NotFoundException(nameof(Domain.LeaveType), request.Id);

        // Convert data object to DTO object
        var data = _mapper.Map<LeaveTypeDetailsDto>(leaveType);

        // Return list of DTO objects
        return data;
    }
}