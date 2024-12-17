﻿using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Commands.UpdateSearchConsumer;

public class UpdateSearchConsumerCommand : IRequest
{
    public int Id { get; set; }
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