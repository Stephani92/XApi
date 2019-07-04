using System;
using XApi.Domain.Enum;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AltePessoaRequest
    {
        public Guid Id { get; set; }
        public string PNome { get; set; }
        public string UNome { get; set; }
        public string Email { get; set; }
        public ESituaPessoa status { get; set; }

    }
}
