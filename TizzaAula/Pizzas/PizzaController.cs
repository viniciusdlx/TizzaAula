using Microsoft.AspNetCore.Mvc;

namespace TizzaAula
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {

        private IServPizza _servPizza;

        public PizzaController(IServPizza servPizza)
        {
            _servPizza = servPizza;

        }

        [HttpPost]
        public ActionResult Inserir(Pizza pizza)
        {
            try
            {
                _servPizza.Inserir(pizza);

                return Ok();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

    }
}
