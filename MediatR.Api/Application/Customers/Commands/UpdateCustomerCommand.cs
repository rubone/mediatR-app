using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Commands;

public class UpdateCustomerCommand : IRequest<Customer>
{
    public Customer Customer { get; set; }
}
