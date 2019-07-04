using System;
using XApi.Domain.Arguments.Pessoa;
using XApi.Domain.Entities;
using XApi.Domain.Interfaces.Repositories.Base;

namespace XApi.Domain.Interfaces.Repositories
{
    public interface IRepositoryPessoa : IRepositoryBase<Pessoa, Guid>
    {


        //Pessoa autenPessRepository(AutenPessoaRequest request);
        //Pessoa addPessRepository(Pessoa request);
        //IEnumerable<Pessoa> ListaPessoas();
        //Pessoa ObterPorId(Guid id);
        //AltePessoaResponse AlterarPessoa(Pessoa request);
    }
}