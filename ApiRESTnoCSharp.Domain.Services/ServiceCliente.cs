using ApiRESTnoCSharp.Domain.Core.Interfaces.Repositories;
using ApiRESTnoCSharp.Domain.Core.Interfaces.Services;
using ApiRESTnoCSharp.Domain.Entities;

namespace ApiRESTnoCSharp.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
