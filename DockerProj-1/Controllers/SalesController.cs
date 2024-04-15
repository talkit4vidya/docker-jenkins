using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerProj_1.DataAccess;
using DockerProj_1.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace DockerProj_1.Controllers
{

    [ApiController]
    [Route("api/sales")]
    public class SalesController : Controller
    {

        Database _context;

        public SalesController(Database dbContext)
        {
            _context = dbContext;

        }

        [HttpGet]
        [Route("docker")]
        public string DockerStatus()
        {
            return "docker publish is successful";

        }


        [HttpGet]
        [Route("getSales")]
        public IEnumerable<Sales> GetSales()
        {
            return _context.sales.AsEnumerable();
            
        }

        [HttpPost]
        [Route("create")]
        public string InsertSales([FromBody] Sales sale)
        {
            var response = _context.sales.AddAsync(sale).Result;
            _context.SaveChanges();
            if (response != null)
                return "inserted successfully";

            return "not suceess";

        }

        [HttpGet]
        [Route("{id}")]
        public Sales? GetSalesById(int id)
        {
            Sales sale = null;
            sale = _context.sales.Where(s => s.id == id).FirstOrDefault();
            
            return sale;

        }


    }
}

