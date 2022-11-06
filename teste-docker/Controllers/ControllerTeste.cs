using Microsoft.AspNetCore.Mvc;

namespace teste_docker.Controllers
{
    [Route("teste")]
    public class ControllerTeste : ControllerBase
    {

        [Route("listar")]
        public string Listar()
        {
            return "sdaksjdasdasd";
        }
        
    }
}
