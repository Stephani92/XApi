using XApi.Domain.Interfaces.Arguments;

namespace XApi.Domain.Arguments.Pessoa
{
    public class AutenPessoaResponse : IResponse
    {
        public string FirstNome { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator AutenPessoaResponse(Entities.Pessoa v)
        {
            return new AutenPessoaResponse()
            {
                Email = v.Email.End,
                FirstNome = v.Nome.FirsName,
                Status = (int)v.status
            };
        }
    }
}
