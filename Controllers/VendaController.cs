using Microsoft.AspNetCore.Mvc;
using VendasApi.Models;
using VendasApi.Responses;
using VendasApi.Repositories;

namespace VendasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] Vendas_produtos vendas)
        {
            BaseRepository.InsertVenda(vendas);

            var retorno = new ReturnResponse()
            {
                
                Code = 200,
                Message = "Venda Registrada!"
            };
            return retorno;
        }
    }
}
