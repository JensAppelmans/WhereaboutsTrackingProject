using Whereabouts.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Whereabouts.Core;
using Whereabouts.Core.Repositories;
using AutoMapper;
using Whereabouts.API.Models;

namespace Whereabouts.API.Controllers
{
    
    public class CustomersController : ApiController
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public CustomersController(IUnitOfWork work, IMapper mapper)
        {
            _work = work;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult getCustomers()
        {
            try
            {
                var result = _work.Customers.GetAll();

                var mappedResult = _mapper.Map<IEnumerable<CustomerModel>>(result);
                 return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
             
        }

        
        [HttpGet]
        public IHttpActionResult getCustomersById(int id)
        {
            try
            {
                var customer = _work.Customers.GetById(id); 
                if (customer == null) return NotFound(); 
                else return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
