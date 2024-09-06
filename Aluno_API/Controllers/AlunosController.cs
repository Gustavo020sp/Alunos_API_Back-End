using Aluno_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aluno_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        //injeção de dependência 
        private readonly IAlunosService alunosService;

        public AlunosController(IAlunosService alunosService)
        {
            this.alunosService = alunosService;
        }
    }
}
