using Microsoft.AspNetCore.Mvc;

namespace TizzaAula
{
    [ApiController]
    [Route("[controller]")]
    public class PromoverController : ControllerBase
    {
        private IServPromover _servPromover;

        public PromoverController(IServPromover servPromover)
        {
            _servPromover = servPromover;
        }
        [HttpPost]
        public IActionResult Inserir(InserirPromoverDTO inserirPromoverDto)
        {
            try
            {
                _servPromover.Inserir(inserirPromoverDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/[Controller]/Efetivar/{id}")]
        [HttpPost]
        public IActionResult Efetivar(int id)
        {
            try
            {
                _servPromover.Efetivar(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/[Controller]/Desfazer/{id}")]
        [HttpPut]
        public IActionResult Desfazer(int id)
        {
            try
            {
                _servPromover.Desfazer(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                var lista = _servPromover.Listar();
                return Ok(lista);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]
        public IActionResult BuscarPromover(int id)
        {
            try
            {
                var promocao = _servPromover.BuscarPromover(id);
                return Ok(promocao);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
    }
}
