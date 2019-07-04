using System;
using XApi.Domain.Entities;
using XApi.Domain.Enum;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AltePessoaResponse
    {
        public Guid Id { get; set; }
        public string PNome { get; set; }
        public string UNome { get; set; }
        public string Email { get; set; }
        public ESituaPessoa status { get; set; }
        public string Msg { get; set; }

        public static explicit operator AltePessoaResponse(Entities.Pessoa v)
        {
            return new AltePessoaResponse()
            {
                Id = v.Id,
                PNome = v.Nome.FirsName,
                UNome = v.Nome.LastName,
                Email = v.Email.End,
                status = v.status
            };
        }
    }
}
