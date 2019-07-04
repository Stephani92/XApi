using System;

namespace XApi.Domain.Entities
{
    class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Desc { get; set; }
        public string Produtora { get; set; }
        public string Distrib { get; set; }
        public string Genero { get; set; }
        public string Site { get; set; }

    }
}
