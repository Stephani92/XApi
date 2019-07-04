using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XApi.Domain.Entities.Obj.Values;
using XApi.Domain.Enum;
using XApi.Domain.Extensions;
using XApi.Domain.Resouces;
using XApi.Domain.Entities.Base;

namespace XApi.Domain.Entities
{
    public class Pessoa : EntityBase
    {
        public Pessoa(string email, string senha)
        {
            Email = new Email(email);
            Senha = senha;
            new AddNotifications<Pessoa>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, RMsg.X1_INVALIDO.ToFormat("Senha"));
            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(Email);
        }

        public Pessoa(string PNome, string LNome, string email, string senha)
        {
            Nome = new Nome(PNome, LNome);
            Email = new Email(email);            
            Senha = senha;
            status = ESituaPessoa.EmAnalise;

            new AddNotifications<Pessoa>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, RMsg.X1_INVALIDO.ToFormat("Senha"));
            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(Email, Nome);
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public ESituaPessoa status { get; private set; }

        public void AlterarPessoa(Nome n, Email e, ESituaPessoa s)
        {
            Nome = n;
            Email = e;
            new AddNotifications<Pessoa>(this).IfFalse(s == ESituaPessoa.Ativo, "Não ativo");
            AddNotification(n.ToString(), e.End);
        }

        public override string ToString()
        {
            return this.Nome.FirsName + " " + this.Nome.LastName;
        }
    }
}
