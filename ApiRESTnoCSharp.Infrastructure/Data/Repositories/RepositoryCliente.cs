using ApiRESTnoCSharp.Domain.Core.Interfaces.Repositories;
using ApiRESTnoCSharp.Domain.Entities;

namespace ApiRESTnoCSharp.Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
