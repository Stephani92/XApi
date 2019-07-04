using System;
using XApi.Domain.Interfaces.Arguments;

namespace XApi.Domain.Arguments.Plataforma
{
    class AddPlatafResponse: IResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Msg { get; set; }

    }
}
