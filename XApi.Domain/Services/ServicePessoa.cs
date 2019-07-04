using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XApi.Domain.Arguments.Base;
using XApi.Domain.Arguments.Pessoa;
using XApi.Domain.Entities;
using XApi.Domain.Entities.Obj.Values;
using XApi.Domain.Interfaces.Repositories;
using XApi.Domain.Interfaces.Services;
using XApi.Domain.Resouces;

namespace XApi.Domain.Services
{
    public class  ServicePessoa : Notifiable, IServPessoa
    {
        private readonly IRepositoryPessoa _repositoryPessoa;
        
        public ServicePessoa(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }        

        public AddPessoaResponse AddPessoa(AddPessoaRequest request)
        {
            var pessoa = new Pessoa(request.PrimeiroNome , request.UltimoNome, request.Email, request.Senha);
            AddNotifications(pessoa);

            if (IsInvalid())
            {
                return null;
            }
            pessoa = _repositoryPessoa.Adicionar(pessoa);
            return (AddPessoaResponse)pessoa;
        }

        public AltePessoaResponse AlterarPessoa(AltePessoaRequest request)
        {
            if (request == null)
            {
                AddNotification("AltePessoaRequest", "Nulo");
                return null;
            }
            Pessoa p = _repositoryPessoa.ObterPorId(request.Id);
            if (p == null)
            {
                AddNotification("Id", "Esta nulo");
                return null;
            }
            var email = new Email(request.Email);
            var nome = new Nome(request.PNome, request.UNome);

            p.AlterarPessoa(nome, email, request.status);
            AddNotifications(p);
            if (IsInvalid())
            {
                return null;
            }

            _repositoryPessoa.Editar(p); 
            return (AltePessoaResponse)p;


        }
               
        public AutenPessoaResponse AutenPessoa(AutenPessoaRequest request)
        {
            

            if (request == null)
            {
                AddNotification("AutenPessoaRequest", RMsg.XO_E_OBRIGATORIO.ToFormat("Falta dados"));
            }
            var pessoa = new Pessoa(request.Email, request.Senha);
            
            if (pessoa.IsInvalid())
            {                
                return null;
            }
            else
            {
                pessoa = _repositoryPessoa.ObterPor(x=>x.Email == pessoa.Email, x=>x.Senha== pessoa.Senha);
                pessoa = _repositoryPessoa.Editar(pessoa);
                return (AutenPessoaResponse)pessoa;
            }
        }

        public IEnumerable<PessoaResponse> ListaPessoas()
        {
            return _repositoryPessoa.Listar().Select(pessoa => (PessoaResponse)pessoa).ToList(); 
        }

        public Pessoa ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResponseBase RemoverPorId(Guid Id)
        {
            Pessoa pessoa = _repositoryPessoa.ObterPorId(Id);
            if (pessoa == null)
            {
                AddNotification("Id", RMsg.XO_E_OBRIGATORIO);
                return null;
            }
            else
            {
                _repositoryPessoa.Remover(pessoa);
                return new ResponseBase() { MessagemBase = RMsg.X2_OK };

            }
        }
    }
}
