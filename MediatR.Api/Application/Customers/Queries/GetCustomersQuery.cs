using MediatR.Api.Data;
using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Queries;

public class GetCustomersQuery : IRequest<List<Customer>>
{

}
