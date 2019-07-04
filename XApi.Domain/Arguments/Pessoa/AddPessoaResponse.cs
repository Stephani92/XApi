using prmToolkit.NotificationPattern.Extensions;
using System;
using XApi.Domain.Interfaces.Arguments;
using XApi.Domain.Resouces;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AddPessoaResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Msg { get; set; }

        public static explicit operator AddPessoaResponse(Entities.Pessoa v)
        {
            return new AddPessoaResponse()
            {
                Id = v.Id,
                Msg = RMsg.X2_OK.ToFormat("Cadastro")
            };

        }
    }
}
