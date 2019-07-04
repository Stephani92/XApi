using XApi.Domain.Interfaces.Arguments;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AddPessoaRequest : IRequest
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
