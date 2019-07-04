using XApi.Domain.Interfaces.Arguments;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AutenPessoaRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public static explicit operator AutenPessoaRequest(Entities.Pessoa v)
        {
            return new AutenPessoaRequest()
            {
                Email = v.Email.End,
                Senha = v.Senha
            };
        }
    }
}
