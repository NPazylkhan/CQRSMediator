using MediatR;

namespace CQRSMediator.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
