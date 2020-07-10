using DevCA.Business.Notifications;
using System.Collections.Generic;

namespace DevCA.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);
    }
}
