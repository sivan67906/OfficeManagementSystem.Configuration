﻿using MediatR;

namespace Configuration.Application.Features.Consumers.Commands.CreateConsumer;

public class CreateConsumerCommand : IRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int PlanTypeId { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Website { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}
