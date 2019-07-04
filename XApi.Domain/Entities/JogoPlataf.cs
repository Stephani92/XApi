using System;

namespace XApi.Domain.Entities
{
    class JogoPlataf
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime DateLanc { get; set; }


    }
}
