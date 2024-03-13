using Microsoft.AspNetCore.Mvc;

namespace TizzaAula
{
    [ApiController]
    [Route("[controller]")]
    public class PizzariaController: ControllerBase
    {

        private IServPizzaria _servPizzaria;

        public PizzariaController(IServPizzaria servPizzaria)
        {
            _servPizzaria = servPizzaria;

        }

        [HttpPost]
        public ActionResult Inserir(Pizzaria pizzaria)
        {
            try
            {
                _servPizzaria.Inserir(pizzaria);

                return Ok();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [Route("[controller]/{id}")]
        [HttpPut]
        public ActionResult Update(int id, [FromBody] UpdatePizzariaDto updatePizzariaDto)
        {
            try
            {
                _servPizzaria.Update(id, updatePizzariaDto);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
