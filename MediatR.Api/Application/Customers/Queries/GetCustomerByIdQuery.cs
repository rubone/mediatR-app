using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Queries;

public class GetCustomerByIdQuery : IRequest<Customer>
{
    public Guid Id { get; set; }
}