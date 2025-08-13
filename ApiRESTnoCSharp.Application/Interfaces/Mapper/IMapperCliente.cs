using ApiRESTnoCSharp.Application.Dtos;
using ApiRESTnoCSharp.Domain.Entities;

namespace ApiRESTnoCSharp.Application.Interfaces.Mapper
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
