using System;
using XApi.Domain.Entities;
using XApi.Domain.Interfaces.Repositories;
using XApi.Infra.Persistence.Repositories.Base;

namespace XApi.Infra.Persistence.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa, Guid>, IRepositoryPessoa
    {
        protected readonly XApiContext context;

        public RepositoryPessoa(XApiContext context):base (context)
        {
            this.context = context;
        }
    }
}
