using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XApi.Domain.Resouces;

namespace XApi.Domain.Entities.Obj.Values
{
    public class Email : Notifiable
    {
        public Email(string end)
        {
            End = end;
            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.End, RMsg.X1_INVALIDO.ToFormat("Email"));
        }

        public string End { get; set; }
    }
}
