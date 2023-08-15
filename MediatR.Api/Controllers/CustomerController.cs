using MediatR.Api.Application.Customers.Commands;
using MediatR.Api.Application.Customers.Queries;
using MediatR.Api.Domain.Entities;
using MediatR.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;
    
    private readonly ILogger<CustomerController> _logger;
    
    public CustomerController(IMediator mediator, ILogger<CustomerController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetCustomersQuery());
        
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var result = await _mediator.Send(new GetCustomerByIdQuery{ Id = id});
        
        return Ok(result);
    }
    
    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateCustomerModel createCustomerModel)
    {
        var customer = new Customer
        {
            FirstName = createCustomerModel.FirstName,
            LastName = createCustomerModel.LastName,
            Birthday = createCustomerModel.Birthday,
            Age = createCustomerModel.Age,
            Phone = createCustomerModel.Phone
        };
        
        var result = await _mediator.Send(new CreateCustomerCommand{ Customer = customer});
        
        return Ok(result);
    }
    
    [HttpPut("update")]
    public async Task<IActionResult> Update([FromBody] UpdateCustomerModel updateCustomerModel)
    {
        var existingCustomer = await _mediator.Send(new GetCustomerByIdQuery{ Id = updateCustomerModel.Id});
        
        if (existingCustomer == null)
        {
            return NotFound();
        }
        
        var customer = new Customer
        {
            Id = updateCustomerModel.Id,
            FirstName = updateCustomerModel.FirstName,
            LastName = updateCustomerModel.LastName,
            Birthday = updateCustomerModel.Birthday,
            Age = updateCustomerModel.Age,
            Phone = updateCustomerModel.Phone
        };
        
        var result = await _mediator.Send(new UpdateCustomerCommand{ Customer = customer});
        
        return Ok(result);
    }
}