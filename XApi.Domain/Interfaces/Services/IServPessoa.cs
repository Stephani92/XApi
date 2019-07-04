using System;
using System.Collections.Generic;
using XApi.Domain.Arguments.Base;
using XApi.Domain.Arguments.Pessoa;
using XApi.Domain.Entities;
using XApi.Domain.Interfaces.Services.Base;

namespace XApi.Domain.Interfaces.Services
{
    public interface IServPessoa: IServiceBase
    {
        AddPessoaResponse AddPessoa(AddPessoaRequest request);
        AutenPessoaResponse AutenPessoa(AutenPessoaRequest request);
        AltePessoaResponse AlterarPessoa(AltePessoaRequest request);
        IEnumerable<PessoaResponse> ListaPessoas();
        Pessoa ObterPorId(Guid id);
        ResponseBase RemoverPorId(Guid Id);
    }
}
