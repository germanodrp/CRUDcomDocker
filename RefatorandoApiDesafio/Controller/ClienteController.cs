using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RefatorandoApiDesafio.Context;
using RefatorandoApiDesafio.Models;

namespace RefatorandoApiDesafio.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ContextCliente _context;

        public ClienteController(ContextCliente contexto)
        {
            this._context = contexto;
            this._context.Set<Cliente>();
        }

        [HttpGet]
        [Route("api/v1/cliente")]
        public ActionResult<Cliente> BuscarTodosClientes()
        {
            var buscarTodos = _context.Cliente.ToList();
            return Ok(buscarTodos);
        }

        [HttpGet]
        [Route("api/v1/cliente/{cpf}")]
        public ActionResult<Cliente>BuscarPorCpf(string cpf)
        {
            var buscaCliente = _context.Cliente.Find(cpf);

            return Ok(buscaCliente);
        }

        [HttpPost]
        [Route("api/v1/cliente")]
        public ActionResult<String>AdicionarCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges(); 

            return Ok("Cliente Adicionado !!");
        }

        [HttpPut]
        [Route("api/v1/cliente/{cpf}")]
        public ActionResult<String> AtualizarCliente(Cliente cliente,string cpf)
        {
            
            if (cpf != cliente.Cpf)
            {
                return BadRequest("Cpf não encontrado");
            }

            _context.Cliente.Update(cliente);
            _context.SaveChanges();

            return Ok("Cliente Atualizado!!");
        }

        [HttpDelete]
        [Route("api/v1/cliente/{cpf}")]
        public ActionResult<Cliente> DeletarCliente(string cpf)
        {

            if(cpf == null)
            {
                return BadRequest("Cliente não encontrado!!");
            }
           var buscarClientePorCpf= _context.Cliente.Find(cpf);
           _context.Cliente.Remove(buscarClientePorCpf!);
           _context.SaveChanges();

            return Ok(buscarClientePorCpf);
        }
    }
}
