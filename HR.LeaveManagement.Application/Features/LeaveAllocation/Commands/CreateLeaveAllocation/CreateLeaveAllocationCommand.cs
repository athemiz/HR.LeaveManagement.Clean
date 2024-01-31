using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public record CreateLeaveAllocationCommand : IRequest<Unit>
{
    public int LeaveTypeId { get; set; }
}
