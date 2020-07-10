using DevCA.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevCA.App.Controllers
{
    public abstract class BaseController : Controller 
    {
        private readonly INotificador _notificador;

        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            //Se tem notificação a operação não é válida
            return !_notificador.TemNotificacao();
        }
    }
}
