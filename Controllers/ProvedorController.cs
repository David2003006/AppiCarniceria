using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCarniceria.BD;

namespace WebAppCarniceria.Controllers
{
    [Route("api/Provedor")]
    [ApiController]
    public class ProvedorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Provedor>>Get()
        {
            return new List<Provedor>()
            {
                new Provedor() { Id_provedor = 1, Nombre = "David Alejandro", Matricula = 147852},
                 new Provedor() { Id_provedor = 2, Nombre = "Jorge Alejandro", Matricula = 156487}
            };
        }
    }
}
