using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;