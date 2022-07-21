using MediatR;

namespace CQRSMediator.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
