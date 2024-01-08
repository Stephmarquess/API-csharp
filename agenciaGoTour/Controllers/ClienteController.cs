using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using agenciaGoTour.Data;
using agenciaGoTour.Model;

namespace agenciaGoTour.Controllers
{
    [ApiController]
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        private readonly DataContext _dataContext;


        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _dataContext.Cliente.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteById(int id)
        {
            var cliente = await _dataContext.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
    }


}
