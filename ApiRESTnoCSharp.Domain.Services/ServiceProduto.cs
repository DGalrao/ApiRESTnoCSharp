using ApiRESTnoCSharp.Domain.Core.Interfaces.Repositories;
using ApiRESTnoCSharp.Domain.Core.Interfaces.Services;
using ApiRESTnoCSharp.Domain.Entities;

namespace ApiRESTnoCSharp.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
