using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Commands;

public class CreateCustomerCommand : IRequest<Customer>
{
    public Customer Customer { get; set; }
}
