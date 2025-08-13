using ApiRESTnoCSharp.Application.Dtos;
using ApiRESTnoCSharp.Domain.Entities;

namespace ApiRESTnoCSharp.Application.Interfaces.Mapper
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
