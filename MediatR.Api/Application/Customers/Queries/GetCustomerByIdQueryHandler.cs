using MediatR.Api.Data;
using MediatR.Api.Domain.Entities;

namespace MediatR.Api.Application.Customers.Queries;

public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
{
    private readonly IRepository<Customer> _repository;
    
    public GetCustomerByIdQueryHandler(IRepository<Customer> repository)
    {
        _repository = repository;
    }
    
    public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        return _repository.GetAll().FirstOrDefault(x => x.Id == request.Id);
    }
}
