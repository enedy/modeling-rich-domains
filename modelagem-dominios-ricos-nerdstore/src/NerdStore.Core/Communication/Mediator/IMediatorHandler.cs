using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.DomainEvents;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace NerdStore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        // EVENTOS QUE OCORREM EM OUTROS DOMINIOS / EVENTOS DE NEGÓCIO / EVENTO DA AGREGACAO (ENTIDADE)
        Task PublicarEvento<T>(T evento) where T : Event;
        // COMANDO CQRS
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        // EXCECOES/NOTIFICACOES PARA O USUARIO
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        // EVENTOS QUE OCORREM DENTRO DO MESMO DOMINIO (ACOES COMO ENVIAR UM EMAIL / ALGO QUE PRECISA SER TRATADO / INFORMATIVO)
        // ALGO QUE OCORREU DENTRO DO DOMINIO E QUE VC QUEIRA QUE OUTRAS PARTES DO MESMO DOMINIO TENHA CONHECIMENTO
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}
