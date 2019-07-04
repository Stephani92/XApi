using XApi.Domain.Interfaces.Arguments;

namespace XApi.Domain.Arguments.Plataforma
{
    class AddPlatafRequest:IRequest
    {
        public string Nome { get; set; }
    }
}
