using MediatR.Api.Data;
using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Queries;

public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
{
    private readonly IRepository<Customer> _repository;
    
    public GetCustomersQueryHandler(IRepository<Customer> repository)
    {
        _repository = repository;
    }
    
    public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        return _repository.GetAll().ToList();
    }
}
