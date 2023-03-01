using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCarniceria.BD;

namespace WebAppCarniceria.Controllers
{
    [Route("api/Carniceria")]
    [ApiController]
    public class CarniceriaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Carniceria>> Get()
        {
            return new List<Carniceria>()
            {
                new Carniceria() { Id = 1, Nombre =  "Ramos", Direccion= "Avenida Don quijote #745"},
                new Carniceria() {  Id = 2, Nombre = "el puerco", Direccion= "Avenida fundadores #304 "}
            };
        }
    }
}