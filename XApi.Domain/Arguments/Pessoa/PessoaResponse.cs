using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XApi.Domain.Entities;
using XApi.Domain.Enum;

namespace XApi.Domain.Arguments.Pessoa
{
    public class PessoaResponse
    {
        public Guid Id { get; set; }
        public string PNome { get; set; }
        public string NomeCompleto { get; set; }
        public string UNome { get; set; }
        public string Email { get; set; }
        public ESituaPessoa status { get; set; }

        public static explicit operator PessoaResponse(Entities.Pessoa v)
        {
            return new PessoaResponse()
            {
                Id = v.Id,
                PNome = v.Nome.FirsName,
                UNome = v.Nome.LastName,
                Email = v.Email.End,
                status = v.status,
                NomeCompleto = v.ToString()
            };
        }
    }
}
