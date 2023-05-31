using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData.Api.Models;

namespace OData.Api.Controllers
{
  
    public class ProductsController : ODataController
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        [EnableQuery]
     
        public IActionResult Get()
        {
            return Ok(_context.Products);
        }
        
        [EnableQuery]
        public IActionResult Get([FromODataUri] int key)
        {
            return Ok(_context.Products.Where(x=> x.Id == key));
        }
    }
}
