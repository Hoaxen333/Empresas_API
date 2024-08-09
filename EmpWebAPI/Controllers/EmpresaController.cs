using EmpWebAPI.Data;
using EmpWebAPI.Models;
using EmpWebAPI.Models.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        [HttpGet]
        public ActionResult< IEnumerable<EmpresaDto>> GetEmpresas() {
            return Ok(EmpresasStore.empresas);
        }
        [HttpGet("id:int")]
        public ActionResult<EmpresaDto> GetEmpresas(int id) {
            if (id == 0) { 
                return BadRequest();
            }
            var empresa = EmpresasStore.empresas.FirstOrDefault(e => e.Id == id);

            if (empresa == null) { 
                return NotFound();
            }
            return Ok(empresa);
        }

    }
}
