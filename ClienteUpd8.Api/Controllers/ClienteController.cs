using ClienteUpd8.Api.Data;
using ClienteUpd8.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class modelsController : ControllerBase
    {
        private readonly DataContext _context;

        public modelsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()

        {
            var model = _context.Clientes.ToList();

            return Ok(model);
        }


        [HttpPost]

        public ActionResult<Cliente> AdicionarCliente(int Id,
            string cpf, 
            string Nome, 
            DateTime DataNacimento, 
            Sexo Sexo, 
            string Endereco, 
            Estado Estado) 
        {
            var model = new Cliente(Id, cpf ,Nome, DataNacimento, Sexo, Endereco, Estado);

            var test = _context.Add(model);
            _context.SaveChangesAsync();
            return Ok(model);

        }
        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(int id, Cliente model)
        {
            _context.Update(model);
            _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete("remove/{id}")]
        public IActionResult RemoverCliente(int id)
        {
            var model = _context.Clientes.Find(id);
            _context.Remove(model);
            _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpGet("pesquisar-cliente")]
        public IActionResult GetByName(string nome)
        {
            var model = _context.Clientes.Where(i => i.Nome.Contains(nome)).ToList();
            return Ok(model);
        }



    }
}