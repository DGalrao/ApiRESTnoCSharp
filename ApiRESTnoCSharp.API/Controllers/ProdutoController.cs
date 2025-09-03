using Microsoft.AspNetCore.Mvc;
using ApiRESTnoCSharp.Application.Dtos;
using ApiRESTnoCSharp.Application.Interfaces;

namespace ApiRESTnoCSharp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: ", ex);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: ", ex);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: ", ex);
            }
        }
    }
}
