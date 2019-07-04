using System;

namespace XApi.Domain.Entities
{
    class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlataf JogoPlataf { get; set; }
        public bool Desejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
        public DateTime DateTime { get; set; }

    }
}
