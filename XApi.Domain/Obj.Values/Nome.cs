using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XApi.Domain.Resouces;

namespace XApi.Domain.Entities.Obj.Values
{
    public class Nome: Notifiable
    {
        public Nome(string firsName, string lastName)
        {
            FirsName = firsName;
            LastName = lastName;
            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.FirsName, 3, 50, RMsg.X1_INVALIDO.ToFormat("Nome"))
                .IfNullOrInvalidLength(x => x.LastName, 3, 50, RMsg.X1_INVALIDO.ToFormat("Nome"));

        }

        public string FirsName { get; private set; }

        public string LastName { get; private set; }
    }
}
