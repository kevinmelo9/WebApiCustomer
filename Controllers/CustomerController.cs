using Microsoft.AspNetCore.Mvc;
using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Controllers.Base;
using webapiTercero.Dommain.Entities;

namespace webapiTercero.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController :BaseController
    {
        private readonly ILogger<CustomerController> _logger;

        private readonly IUnitOfWork _unitofwork;
        
        public CustomerController(ILogger<CustomerController> logger,
                                  IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitofwork = unitOfWork;
            
        }
// GET: /Customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _unitofwork.Customers.GetAll();   
        }

        // GET: /Customers/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _unitofwork.Customers.GetById(id);
        }
        
        // POST: /Customers/5
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _unitofwork.Customers.Add(customer);
            _unitofwork.Complete();
        }
        
        // PUT: /Customers/5
        [HttpPut]
        public void Put(int id, [FromBody] Customer customer)
        {
            _unitofwork.Customers.Update(id,customer);
            _unitofwork.Complete();
        }

        // PUT: /Customers/5
        [HttpDelete]
        public void Delete(int id, Customer customer)
        {
            _unitofwork.Customers.Remove(customer);
            _unitofwork.Complete();
        }



    }
}